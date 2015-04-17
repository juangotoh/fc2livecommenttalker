Imports System
Imports System.IO
Imports System.IO.Stream
Imports System.IO.MemoryStream
Imports System.Collections.Specialized
Imports System.Web
Imports System.Web.Script.Serialization.JavaScriptSerializer
Imports System.Runtime.Serialization
Imports System.Runtime.Serialization.Json
Imports System.Runtime.InteropServices
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports Microsoft.VisualBasic
Imports System.Threading
Imports System.Speech.Synthesis
Imports System.Collections.ObjectModel
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class Form1
    Private Shared _form1Instance As Form1
    Public Shared Property Form1Instance() As Form1
        Get
            Return _form1Instance
        End Get
        Set(ByVal Value As Form1)
            _form1Instance = Value
        End Set
    End Property
    Public Property TextBox_ChannelText() As String
        Get
            Return TextBox_Channel.Text
        End Get
        Set(ByVal Value As String)
            TextBox_Channel.Text = Value
        End Set
    End Property
    ' ソケット・リスナー
    Private myListener As Sockets.TcpListener
    ' クライアント送受信
    Private myClient As ClientTcpIp = New ClientTcpIp




    ' Set the TcpListener on port 13000.
    'Dim port As Int32 = 50001
    Dim port As Int32 = 8888
    Dim localAddr As IPAddress = IPAddress.Parse("127.0.0.1")
    Dim volume As Integer
    Dim isTextChanged As Boolean = False
    Dim namestr As String
    Dim commentstr As String
    Dim transname As String
    Dim transcomment As String
    Dim insertLog As Boolean = False
    Dim chlock As Boolean
    Dim c_channel As String
    Dim lockChanged As Boolean = False
    Dim chChanged As Boolean = False
    Dim chStr As String
    Dim Quit As Boolean = False
    Dim Speed As Integer
    Dim now As DateTime
    Dim skip As Boolean = False
    Dim socketErr As Boolean = True
    Dim kaoDic As New Dictionary(Of String, String)
    Dim myHandle As IntPtr
    Dim logBlock As Boolean = False
    Dim logBuffer As String = ""
    Dim translating As Boolean = False

    Private Function convlongsound(str As String) As String
        Dim l As String = ""

        Dim lineA As String = "([あぁかがさただなはばまやらわアァカガサザタダナハバマヤラワｱｶｻﾀﾅﾊﾏﾔﾗﾜ])([ー～-]+)"
        Dim lineA2 As String = "(ｶﾞ|ｻﾞ|ﾀﾞ|ﾊﾞ)([ー～-]+)"
        Dim lineI As String = "([いぃきぎしじちぢにひびみいりゐイィキギシジチヂニヒビミイリｲｷｼﾁﾆﾋﾐｲﾘ])([ー～-]+)"
        Dim lineI2 As String = "(ｷﾞ|ｼﾞ|ﾁﾞ|ﾋﾞ)([ー～-]+)"
        Dim lineU As String = "([うくぐすずつづぬふむゆるウヴクグスズツヌフブムユルｳｸｽﾂﾇﾌﾑﾕﾙ])([ー～-])+"
        Dim lineU2 As String = "(ｳﾞ|ｸﾞ|ｽﾞ|ﾂﾞ|ﾌﾞ)([ー～-]+)"
        Dim lineE As String = "([えぇけげせぜてでねへべめえれゑエケゲセぜテデネヘベメエレエヱェ])([ー～-]+)"
        Dim lineE2 As String = "(ｹﾞ|ｾﾞ|ﾃﾞ|ﾍﾞ)([ー～-]+)"
        Dim lineO As String = "([おこごそぞとどのほぼもをろオコゴソゾノトドホボモヲロｵｺｿﾄﾉﾎﾓｦﾛ])([ー～-]+)"
        Dim lineO2 As String = "(ｺﾞ|ｿﾞ|ﾄﾞ|ﾎﾞ)([ー～-])+"

        Dim question As String = "(.)[？?]"

        str = System.Text.RegularExpressions.Regex.Replace(str, lineA, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contA))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineA2, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contA))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineI, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contI))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineI2, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contI))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineU, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contU))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineU2, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contU))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineE, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contE))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineE2, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contE))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineO, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contO))
        str = System.Text.RegularExpressions.Regex.Replace(str, lineO2, New System.Text.RegularExpressions.MatchEvaluator(AddressOf contO))
        'str = System.Text.RegularExpressions.Regex.Replace(str, question, "<prosody pitch=""x-high"">$1</prosody>")
        Console.WriteLine(str)
        Return str
    End Function
    Private Shared Function contA(ByVal m As System.Text.RegularExpressions.Match) As String
        Return m.Groups(1).Value + New String("あ", m.Groups(2).Value.Length)
    End Function
    Private Shared Function contI(ByVal m As System.Text.RegularExpressions.Match) As String
        Return m.Groups(1).Value + New String("い", m.Groups(2).Value.Length)
    End Function
    Private Shared Function contU(ByVal m As System.Text.RegularExpressions.Match) As String
        Return m.Groups(1).Value + New String("う", m.Groups(2).Value.Length)
    End Function
    Private Shared Function contE(ByVal m As System.Text.RegularExpressions.Match) As String
        Return m.Groups(1).Value + New String("え", m.Groups(2).Value.Length)
    End Function
    Private Shared Function contO(ByVal m As System.Text.RegularExpressions.Match) As String
        Return m.Groups(1).Value + New String("お", m.Groups(2).Value.Length)
    End Function
    '辞書による文字列置換
    Private Function dict(s As String) As String

        Dim keys As New System.Collections.ArrayList()
        For Each de As KeyValuePair(Of String, String) In kaoDic
            's = s.Replace(de.key, de.Value)
            If s.Contains(de.Key) Then
                keys.Add(de.Key)
            End If

        Next

        Dim comp As New LengthComparer()
        keys.Sort(comp)
        For i As Integer = 0 To keys.Count - 1
            Console.WriteLine(keys(i) + ":" + kaoDic.Item(keys(i)))
            s = s.Replace(keys(i).ToString, kaoDic.Item(keys(i).ToString))
        Next
        For i As Integer = 0 To My.Settings.TransKey.Count - 1
            s = s.Replace(My.Settings.TransKey(i), My.Settings.TransValue(i))
        Next
        Console.WriteLine(s)
        s = convlongsound(s)
        Return s
    End Function

    Public Class LengthComparer
        Implements System.Collections.IComparer

        'xがyより小さいときはマイナスの数、大きいときはプラスの数、同じときは0を返す
        Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
            Implements System.Collections.IComparer.Compare

            'Nothingが最も小さいとする
            If x Is Nothing AndAlso y Is Nothing Then
                Return 0
            End If
            If x Is Nothing Then
                Return -1
            End If
            If y Is Nothing Then
                Return 1
            End If

            'String型以外の比較はエラー
            If Not (TypeOf x Is String) Then
                Throw New ArgumentException("String型でなければなりません。", "x")
            ElseIf Not (TypeOf y Is String) Then
                Throw New ArgumentException("String型でなければなりません。", "y")
            End If

            '文字列の長さを比較する
            Return DirectCast(y, String).Length.CompareTo(DirectCast(x, String).Length)
            'または、次のようにもできる
            'Return DirectCast(x, String).Length - DirectCast(y, String).Length
        End Function
    End Class

    'コメントログ書き出し
    Private Sub WriteCommentLog(ByRef str As String)
        Dim parent As String = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
        Dim mydir As String = My.Application.Info.Title
        'Dim path As String = System.IO.Path.Combine(parent, mydir, "Comment.log")
        Dim path As String = System.IO.Path.Combine(parent, mydir)
        If Not System.IO.File.Exists(path) Then
            System.IO.Directory.CreateDirectory(path)
        End If
        path = System.IO.Path.Combine(path, "Comment.log")
        Dim logFile = New System.IO.StreamWriter(path, True, System.Text.Encoding.UTF8)
        logFile.WriteLine(str)
        logFile.Close()
    End Sub



    ' クライアント接続待ちスレッド
    Private Sub ServerThread()
        Try
            While True
                ' ソケット接続待ち
                Dim myTcpClient As Sockets.TcpClient = myListener.AcceptTcpClient()
                ' クライアントから接続有り

                ' クライアント送受信オブジェクト生成
                myClient = New ClientTcpIp
                myClient.intNo = 1
                myClient.objSck = myTcpClient
                myClient.objStm = myTcpClient.GetStream()
                ' クライアントとの送受信開始
                Dim myClientThread As New Thread( _
                    New ThreadStart(AddressOf myClient.ReadWrite))
                myClientThread.Start()

            End While
        Catch ex As Exception
        End Try
    End Sub

    'JSON対応クラス
    Public Class fc2comment
        Public channel As Integer
        Public userid_hash As String
        Public username As String
        Public ng_flg As Integer
        Public time As ULong
        Public comment As String
    End Class
    

    Public Class AdmAccessToken
        Public access_token As String
        Public token_type As String
        Public expires_in As String
        Public scope As String
    End Class
    ' クライアント送受信クラス
    Public Class ClientTcpIp
        Public intNo As Integer
        Public objSck As Sockets.TcpClient
        Public objStm As Sockets.NetworkStream
        Dim policy As String = "<cross-domain-policy><allow-access-from domain=""*"" to-ports=""*"" /></cross-domain-policy>" & Chr(0)
        Dim policyBytes = System.Text.Encoding.ASCII.GetBytes(policy)
        Dim namestr As String
        Dim commentstr As String
        Dim transstr As String
        Dim speed As Integer = 0
        Dim timestr As String
        Dim now As DateTime

        ' クライアント送受信スレッド
        Public Sub ReadWrite()
            Dim preStr As String = ""
            Dim timeZero As DateTime = New DateTime(1970, 1, 1)
            Try
                While True
                    ' ソケット受信
                    Dim rdat As Byte() = New Byte(1023) {}
                    Dim ldat As Int32 = objStm.Read(rdat, 0, rdat.GetLength(0))

                    If ldat > 0 Then
                        ' クライアントからの受信データ有り
                        ' 送信データ作成
                        Dim sdat As Byte() = New Byte(ldat - 1) {}
                        Array.Copy(rdat, sdat, ldat)
                        Dim msg As String = preStr + System.Text.Encoding.UTF8.GetString(sdat)
                        'Console.WriteLine(rdat)
                        sdat = System.Text.Encoding.UTF8.GetBytes(msg)
                        ' ソケット送信
                        'objStm.Write(sdat, 0, sdat.GetLength(0))
                        If msg.IndexOf("<policy-file-request/>") >= 0 Then
                            'ポリシーファイル要求
                            objStm.Write(policyBytes, 0, policyBytes.GetLength(0))
                        Else
                            'JSONデータ
                            'Dim ms As New MemoryStream(rdat)

                            Dim jss_serial As Web.Script.Serialization.JavaScriptSerializer = New Web.Script.Serialization.JavaScriptSerializer
                            'Dim sl As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(String))
                            'ms.Position = 0
                            Dim sAllay As String() = Split(msg, """}", -1, CompareMethod.Binary)
                            Dim m = sAllay.Length - 1
                            Dim last As String = sAllay(m)
                            If last.EndsWith("}") Then
                                preStr = ""
                            Else
                                preStr = last
                                m = m - 1
                            End If

                            If My.Settings.AutoSpeed Then
                                If m < 1 Then
                                    speed = 0

                                ElseIf m < 2 Then
                                    speed = 5
                                ElseIf m < 3 Then
                                    speed = 8
                                Else
                                    speed = 10
                                End If
                            Else
                                speed = 0
                            End If
                            Form1.Form1Instance.Speed = speed
                            'SetSpeed(speed)
                            For i As Integer = 0 To m
                                If Form1.Form1Instance.Quit Then Return
                                Dim result As fc2comment = jss_serial.Deserialize(Of fc2comment)(sAllay(i) + """}")
                                Console.WriteLine(sAllay(i) + """}")

                                Dim chStr = result.channel.ToString
                                If My.Settings.ChLock Then
                                    If My.Settings.Channel <> result.channel Then
                                        Continue For
                                    End If

                                Else
                                    If My.Settings.Channel <> result.channel Then
                                        Form1.Form1Instance.chStr = chStr
                                        My.Settings.Channel = result.channel
                                        Form1.Form1Instance.logBlock = True
                                        Form1.Form1Instance.WriteCommentLog("■■■■チャンネル:" + chStr)
                                        Form1.Form1Instance.getChannelInfo()
                                    End If
                                    Form1.Form1Instance.chStr = chStr
                                    My.Settings.Channel = result.channel
                                End If
                                If result.ng_flg <> 0 Then
                                    result.comment = "NGコメントまたはNGユーザーです"
                                End If
                                now = timeZero.AddMilliseconds(result.time)
                                now = now.AddHours(9)
                                'SetTime(now)
                                Form1.Form1Instance.now = timeZero.AddMilliseconds(result.time)
                                Form1.Form1Instance.now = Form1.Form1Instance.now.AddHours(9)
                                While Form1.Form1Instance.isTextChanged
                                End While
                                namestr = result.username
                                commentstr = result.comment
                                Form1.Form1Instance.namestr = result.username

                                Form1.Form1Instance.commentstr = result.comment
                                Form1.Form1Instance.insertLog = True
                                'AddLog()
                                'SetLog(namestr, commentstr)
                                Form1.Form1Instance.isTextChanged = True

                                Dim str As String = result.comment
                                Dim needSuffix As Boolean = False
                                If My.Settings.IsLimit And str.Length > My.Settings.Length Then
                                    str = str.Substring(0, My.Settings.Length)
                                    needSuffix = True
                                End If

                                If result.ng_flg = 0 Or My.Settings.IgnoreNGuser = False Then

                                    Try
                                        If My.Settings.Channel = result.channel Or Not My.Settings.ChLock Then
                                            Dim nameFlag As Integer = -1
                                            If My.Settings.ForceJAName Then
                                                nameFlag = 1
                                            End If
                                            If My.Settings.TalkName Then TalkStr(result.username, speed, True)
                                            TalkStr(str, speed, False)
                                            If needSuffix And My.Settings.Suffix.Length > 0 Then TalkStr(My.Settings.Suffix, speed, nameFlag)
                                        End If
                                    Catch ex As System.Runtime.InteropServices.COMException
                                    End Try
                                End If
                            Next
                        End If
                    Else
                        ' ソケット切断有り
                        ' ソケットクローズ
                        objStm.Close()
                        objSck.Close()
                        Return
                    End If
                    If Form1.Quit Then
                        objStm.Close()
                        objSck.Close()
                        Return
                    End If
                End While
            Catch ex As Exception
                Form1.Form1Instance.socketErr = True
            End Try
        End Sub
        Private Sub TalkBouyomi(str As String)
            Dim bMessage As Byte()
            bMessage = System.Text.Encoding.UTF8.GetBytes(str)
            Dim length As Int32 = bMessage.Length
            Dim iCommand As Int16 = 1
            Dim iSpeed As Int16 = -1
            Dim iTone As Int16 = -1
            Dim iVolume As Int16 = -1
            Dim iVoice As Int16 = 0
            Dim bCode As Byte = 0
            Dim sHost As String = "127.0.0.1"
            Dim port As Integer = 50001
            Dim tc As TcpClient
            Try
                tc = New TcpClient(sHost, port)
                Dim ns = tc.GetStream()
                Dim bw As BinaryWriter = New BinaryWriter(ns)
                bw.Write(iCommand)
                bw.Write(iSpeed)
                bw.Write(iTone)
                bw.Write(iVolume)
                bw.Write(iVoice)
                bw.Write(bCode)
                bw.Write(length)
                bw.Write(bMessage)
                tc.Close()
            Catch ex As Exception

            End Try
           
        End Sub
        Private Sub TalkStr(str As String, speed As Integer, isname As Boolean)

            If Form1.Form1Instance.skip Then
                While Form1.Form1Instance.isTextChanged
                End While
                Form1.Form1Instance.isTextChanged = True
                'SetLog(namestr, commentstr)

                Return
            End If
            If str.Length = 0 Then
                While Form1.Form1Instance.isTextChanged
                End While
                Form1.Form1Instance.isTextChanged = True
                'SetLog(namestr, commentstr)
                Return
            End If
            Dim vol As Integer = My.Settings.Volume
            Dim sapiSyn As New System.Speech.Synthesis.SpeechSynthesizer
            Dim l As Integer = str.Length
            Dim i As Integer
            Dim ch As Char
            Dim mode As Integer = 0
            Dim notWestern As Boolean = False
            Dim hasHangle As Boolean = False
            Dim hasKana As Boolean = False
            Dim vname As String = My.Settings.JAvoice
            Dim useMSSpeach As Boolean = False
            Dim lang As String = "ja"
            Dim transStr As String = ""
            Dim outStr As String = ""

            If My.Settings.MultiLang Then
                For i = 0 To l - 1
                    ch = str.Chars(i)
                    If ch > "ÿ" Then
                        notWestern = True
                    End If
                    If ch >= "ᄀ" And ch <= "ᇿ" Then
                        hasHangle = True
                    End If
                    If ch >= "가" And ch <= "힣" Then
                        hasHangle = True
                    End If
                    If ch >= "ぁ" And ch <= "ヿ" Then
                        hasKana = True
                    End If
                    If ch >= "ㇰ" And ch <= "ㇿ" Then
                        hasKana = True
                    End If
                    If ch >= "｡" And ch <= "ﾟ" Then
                        hasKana = True
                    End If
                Next
                If notWestern Then
                    mode = 1
                    If hasHangle And My.Settings.UseKorean Then
                        mode = 2
                    ElseIf hasKana Then
                        mode = 1
                    ElseIf My.Settings.UseChinese Then
                        mode = 3
                        If isname And My.Settings.ForceJAName Then mode = 1
                    End If
                ElseIf My.Settings.UseEnglish Then
                    mode = 0
                End If

            Else
                mode = 1
            End If

            Select Case mode
                Case 0
                    vname = My.Settings.ENvoice
                    lang = "en"
                Case 1
                    lang = "ja"
                    vname = My.Settings.JAvoice
                    str = Form1.Form1Instance.dict(str)
                Case 2
                    vname = My.Settings.KOVoice
                    lang = "ko"
                Case 3
                    vname = My.Settings.ZHVoice
                    lang = "zh-CHT"
            End Select

            Form1.Form1Instance.transcomment = ""
            outStr = str

            If My.Settings.Bouyomi And lang = "ja" Then
                TalkBouyomi(outStr)
            Else
                sapiSyn.SelectVoice(vname)
                Console.WriteLine(sapiSyn.Voice.Name)
                Try
                    sapiSyn.SetOutputToDefaultAudioDevice()
                    sapiSyn.Volume = vol
                    sapiSyn.Rate = speed
                    sapiSyn.Speak(outStr)
                    'speaker.Speakssml(outStr)
                Catch ex As Exception

                End Try
            End If
            If My.Settings.Translate And lang <> "ja" And Not isname Then

                If isname Then

                Else
                    While Form1.Form1Instance.isTextChanged
                    End While
                    Form1.Form1Instance.translating = True
                    Form1.Form1Instance.transcomment = "(翻訳中)"
                    Form1.Form1Instance.isTextChanged = True
                    transStr = Translate(str, lang)
                    Form1.Form1Instance.translating = False
                    While Form1.Form1Instance.isTextChanged
                    End While

                    Form1.Form1Instance.transcomment = "【訳：" + transStr + "】"
                    'Form1.Form1Instance.insertLog = True
                    Form1.Form1Instance.isTextChanged = True
                End If

                ' Form1.Form1Instance.insertLog = True
                Form1.Form1Instance.isTextChanged = True

                'outStr = "<?xml version=""1.0""?><speak version=""1.0"" xmlns=""http://www.w3.org/2001/10/synthesis""  xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xsi:schemaLocation=""http://www.w3.org/2001/10/synthesis http://www.w3.org/TR/speech-synthesis/synthesis.xsd"" xml:lang=""ja"">" + transStr + "</speak>"
                outStr = transStr
                vname = My.Settings.JAvoice
                If My.Settings.Bouyomi Then
                    TalkBouyomi(outStr)
                Else
                    sapiSyn.SelectVoice(vname)
                    Console.WriteLine(sapiSyn.Voice.Name)
                    Try
                        sapiSyn.SetOutputToDefaultAudioDevice()
                        sapiSyn.Volume = vol
                        sapiSyn.Rate = speed
                        sapiSyn.Speak(outStr)
                        'speaker.Speakssml(outStr)
                    Catch ex As Exception

                    End Try
                End If
                'Try
                '    sapiSyn.SelectVoice(vname)
                '    Console.WriteLine(sapiSyn.Voice.Name)
                'Catch ex As ArgumentException

                'End Try
                'Try
                '    sapiSyn.SetOutputToDefaultAudioDevice()
                '    sapiSyn.Volume = vol
                '    sapiSyn.Rate = speed
                '    sapiSyn.Speak(outStr)
                '    'speaker.Speakssml(outStr)
                'Catch ex As Exception

                'End Try
            End If

        End Sub
        Function Translate(src As String, lang As String) As String
            Dim clientID As String = My.Settings.ClientID
            Dim clientSecret As String = My.Settings.ClientSecret
            Dim translatedText As String = ""
            Try
                Dim strTranslatorAccessURI As String = "https://datamarket.accesscontrol.windows.net/v2/OAuth2-13"
                Dim strRequestDetails As String = String.Format("grant_type=client_credentials&client_id={0}&client_secret={1}&scope=http://api.microsofttranslator.com", HttpUtility.UrlEncode(clientID), HttpUtility.UrlEncode(clientSecret))


                Dim webRequest As System.Net.WebRequest = System.Net.WebRequest.Create(strTranslatorAccessURI)
                webRequest.ContentType = "application/x-www-form-urlencoded"
                webRequest.Method = "POST"
                Dim bytes() As Byte = System.Text.Encoding.ASCII.GetBytes(strRequestDetails)
                webRequest.ContentLength = bytes.Length

                Using outputStream As System.IO.Stream = webRequest.GetRequestStream()
                    outputStream.Write(bytes, 0, bytes.Length)
                End Using
                Dim webResponse As System.Net.WebResponse = webRequest.GetResponse()
                ' Make sure you add a reference to System.Runtime.Serialization here
                Dim AdmToken As New AdmAccessToken
                Dim serializer As System.Runtime.Serialization.Json.DataContractJsonSerializer = New System.Runtime.Serialization.Json.DataContractJsonSerializer(AdmToken.GetType())
                Dim token As AdmAccessToken = serializer.ReadObject(webResponse.GetResponseStream())
                Dim headerValue As String = "Bearer " + token.access_token

                ' Call the SOAP Service

                Dim soapClient As New TranslatorService.LanguageServiceClient()
                translatedText = soapClient.Translate(headerValue, src, lang, "ja", "text/plain", "")
            Catch e As Exception
                Console.WriteLine(e.Message)
                MessageBox.Show("翻訳時にエラーが発生しました。" + e.Message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End Try
            Return translatedText
        End Function
        
    End Class

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myHandle = Me.Handle
        Form1.Form1Instance = Me

        If My.Settings.TransKey Is Nothing Then
            My.Settings.TransKey = New StringCollection
            My.Settings.TransValue = New StringCollection
        End If
        If My.Settings.TransKey.Count = 0 Then
            My.Settings.TransKey.Add("w")
            My.Settings.TransValue.Add("わら")
            My.Settings.TransKey.Add("ｗ")
            My.Settings.TransValue.Add("わら")
            My.Settings.TransKey.Add("～")
            My.Settings.TransValue.Add("ー")

        End If
        listUpdate()
        Dim txt As String = My.Resources.google_std
        Dim lines As String() = txt.Split(ControlChars.CrLf)
        For Each line In lines
            'Console.WriteLine(line)
            Dim stBuffer As String() = line.Split(ControlChars.Tab)
            If line.Length > 1 Then
                Try
                    Form1.Form1Instance.kaoDic.Add(stBuffer(1).Trim(), stBuffer(0).Trim())
                    'Console.WriteLine(stBuffer(1).Trim() + ":" + stBuffer(0).Trim())
                Catch ex As System.ArgumentException
                End Try
            End If
        Next



        ' IPアドレス＆ポート番号設定
        Dim myPort As Integer = 8888
        Dim myEndPoint As New IPEndPoint(IPAddress.Parse("127.0.0.1"), myPort)

        ' リスナー開始
        myListener = New Sockets.TcpListener(myEndPoint)
        myListener.Start()

        Timer1.Interval = 50
        Timer1.Start()

        TrackBar_Volume.Value = My.Settings.Volume
        volume = My.Settings.Volume
        Label_Volume.Text = volume.ToString
        CheckBox_HoldChannel.Checked = My.Settings.ChLock
        chlock = My.Settings.ChLock
        c_channel = My.Settings.Channel
        TextBox_Channel.Text = My.Settings.Channel.ToString
        CheckBox_SpeedUp.Checked = My.Settings.AutoSpeed
        CheckBox_DontReadNG.Checked = My.Settings.IgnoreNGuser
        CheckBox_ReadName.Checked = My.Settings.TalkName
        CheckBox_Limi.Checked = My.Settings.IsLimit
        CheckBox_Multi.Checked = My.Settings.MultiLang
        CheckBox_En.Checked = My.Settings.UseEnglish
        CheckBox_Ko.Checked = My.Settings.UseKorean
        CheckBox_Zh.Checked = My.Settings.UseChinese
        CheckBox_NameOpt.Checked = My.Settings.ForceJAName
        CheckBox_Bouyomi.Checked = My.Settings.Bouyomi
        langRefresh()
        TextBox_Limit.Text = My.Settings.Length.ToString
        TextBox_Suffix.Text = My.Settings.Suffix
        limitRefresh()
        Dim syn As System.Speech.Synthesis.SpeechSynthesizer = New System.Speech.Synthesis.SpeechSynthesizer()
        Dim ll As ReadOnlyCollection(Of System.Speech.Synthesis.InstalledVoice) = syn.GetInstalledVoices()
        Console.WriteLine("SAPI5 voices")
        For Each x As System.Speech.Synthesis.InstalledVoice In ll
            If x.VoiceInfo.Culture.Name.StartsWith("ja") Then
                ComboBox_Japanese.Items.Add(x.VoiceInfo.Name)
                If My.Settings.JAvoice.Length = 0 Then My.Settings.JAvoice = x.VoiceInfo.Name
            ElseIf x.VoiceInfo.Culture.Name.StartsWith("en") Then
                ComboBox_English.Items.Add(x.VoiceInfo.Name)
                If My.Settings.ENvoice.Length = 0 Then My.Settings.ENvoice = x.VoiceInfo.Name
            ElseIf x.VoiceInfo.Culture.Name.StartsWith("ko") Then
                ComboBox_Korean.Items.Add(x.VoiceInfo.Name)
                If My.Settings.KOVoice.Length = 0 Then My.Settings.KOVoice = x.VoiceInfo.Name
            ElseIf x.VoiceInfo.Culture.Name.StartsWith("zh") Then
                ComboBox_Chinese.Items.Add(x.VoiceInfo.Name)
                If My.Settings.ZHVoice.Length = 0 Then My.Settings.ZHVoice = x.VoiceInfo.Name
            End If
            Console.WriteLine(x.VoiceInfo.Name)
        Next
        
        Dim i As Integer
        If My.Settings.JAvoice.Length > 0 Then
            i = ComboBox_Japanese.FindString(My.Settings.JAvoice)
            If i < 0 Then
                ComboBox_Japanese.SelectedIndex = 0
                My.Settings.JAvoice = ComboBox_Japanese.SelectedItem
            Else
                ComboBox_Japanese.SelectedIndex = i
            End If

        End If

        If My.Settings.ENvoice.Length > 0 Then
            i = ComboBox_English.FindString(My.Settings.ENvoice)
            If i < 0 Then
                ComboBox_English.SelectedIndex = 0
                My.Settings.ENvoice = ComboBox_English.SelectedItem
            Else
                ComboBox_English.SelectedIndex = i
            End If
        End If

        If My.Settings.KOVoice.Length > 0 Then
            i = ComboBox_Korean.FindString(My.Settings.KOVoice)
            If i < 0 Then
                ComboBox_Korean.SelectedIndex = 0
                My.Settings.KOVoice = ComboBox_Korean.SelectedItem
            Else
                ComboBox_Korean.SelectedIndex = i
            End If


        End If
        If My.Settings.ZHVoice.Length > 0 Then
            i = ComboBox_Chinese.FindString(My.Settings.ZHVoice)
            If i < 0 Then
                ComboBox_Chinese.SelectedIndex = 0
                My.Settings.ZHVoice = ComboBox_Chinese.SelectedItem
            Else
                ComboBox_Chinese.SelectedIndex = i
            End If

        End If

        langRefresh()

        TextBox_ID.Text = My.Settings.ClientID
        TextBox_Secret.Text = My.Settings.ClientSecret
        CheckBox_UseTranslation.Checked = My.Settings.Translate
        Timer2.Interval = 1000
        Timer2.Start()


    End Sub

    Private Sub listUpdate()

        ListView_Dictionary.BeginUpdate()
        Dim num As Integer = ListView_Dictionary.Items.Count
        For i As Integer = 0 To num - 1
            ListView_Dictionary.Items.RemoveAt(0)
        Next
        For i As Integer = 0 To My.Settings.TransKey.Count - 1
            ListView_Dictionary.Items.Add(New ListViewItem({My.Settings.TransKey.Item(i), My.Settings.TransValue(i)}))
        Next
        ListView_Dictionary.FullRowSelect = True
        ListView_Dictionary.EndUpdate()
    End Sub
    Private Sub limitRefresh()
        If CheckBox_Limi.Checked Then
            TextBox_Limit.Enabled = True
            TextBox_Suffix.Enabled = True
        Else
            TextBox_Limit.Enabled = False
            TextBox_Suffix.Enabled = False
        End If
    End Sub
    Private Sub langRefresh()
        If CheckBox_Multi.Checked Then
            If My.Settings.ENvoice.Length > 0 Then
                CheckBox_En.Enabled = True
                ComboBox_English.SelectedIndex = ComboBox_English.FindString(My.Settings.ENvoice)
            Else
                CheckBox_En.Enabled = False
            End If
            If My.Settings.KOVoice.Length > 0 Then
                CheckBox_Ko.Enabled = True
                ComboBox_Korean.SelectedIndex = ComboBox_Korean.FindString(My.Settings.KOVoice)
            Else
                CheckBox_Ko.Enabled = False
            End If

            If My.Settings.ZHVoice.Length > 0 Then
                CheckBox_Zh.Enabled = True
                ComboBox_Chinese.SelectedIndex = ComboBox_Chinese.FindString(My.Settings.ZHVoice)
            Else
                CheckBox_Zh.Enabled = False

            End If
            CheckBox_NameOpt.Enabled = True

        Else
            CheckBox_En.Enabled = False
            CheckBox_Ko.Enabled = False
            CheckBox_Zh.Enabled = False
            CheckBox_NameOpt.Enabled = False
        End If


    End Sub


    Private Sub Form1_FormClosed( _
     ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) _
     Handles MyBase.FormClosed
        Quit = True
        ' リスナー終了
        myListener.Stop()
        ' クライアント切断

        If myClient Is Nothing = False Then
            If myClient.objSck Is Nothing = False Then
                If myClient.objSck.Connected = True Then
                    ' ソケットクローズ
                    myClient.objStm.Close()
                    myClient.objSck.Close()
                End If
            End If

        End If

    End Sub


    Private Sub TrackBar_Volume_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Volume.Scroll
        volume = TrackBar_Volume.Value
        My.Settings.Volume = volume
        Label_Volume.Text = volume.ToString

    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If isTextChanged Then
            TextBox_Channel.Text = chStr
            ListView_Comment.BeginUpdate()
            Label_Speed.Text = Speed.ToString
            Dim timestr = now.ToString("yyyy-MM-dd") + " " + now.ToLongTimeString
            Label_Time.Text = timestr
            If insertLog Then
                insertLog = False
                ListView_Comment.Items.Add(New ListViewItem({"", ""}))
                While ListView_Comment.Items.Count > 1000
                    ListView_Comment.Items(0).Remove()
                End While

            End If
            ListView_Comment.Items(ListView_Comment.Items.Count - 1) = New ListViewItem({namestr, commentstr + transcomment})
            ListView_Comment.EnsureVisible(ListView_Comment.Items.Count - 1)
            ListView_Comment.EndUpdate()
            Dim logline = timestr + ControlChars.Tab + namestr + ControlChars.Tab + commentstr + transcomment
            If transcomment.IndexOf("【訳") >= 0 Then
                transcomment = transcomment.Substring(3, transcomment.Length - 4)
                logline = timestr + ControlChars.Tab + "自動翻訳" + ControlChars.Tab + transcomment
            End If
            If logBlock Then
                If Not translating Then
                    logBuffer += logline + ControlChars.NewLine
                End If

            Else

                logBuffer = logBuffer.TrimEnd()
                If logBuffer.Length > 0 Then
                    WriteCommentLog(logBuffer)
                    logBuffer = ""
                End If
                If Not translating Then
                    WriteCommentLog(logline)
                End If
            End If
            transcomment = ""
            isTextChanged = False


        End If
        If chChanged Then
            chChanged = False

        End If
        If socketErr Then
            socketErr = False


            ' クライアント接続待ち開始
            Dim myServerThread As New Thread(New ThreadStart(AddressOf ServerThread))
            myServerThread.Start()
        End If
    End Sub

    Private Sub CheckBox_HoldChannel_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_HoldChannel.CheckedChanged
        chlock = CheckBox_HoldChannel.Checked
        lockChanged = True
        My.Settings.ChLock = chlock
    End Sub

    Private Sub TextBox_Channel_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Channel.TextChanged

        My.Settings.Channel = TextBox_Channel.Text

        Timer2.Interval = 100
    End Sub

    Private Sub ListView_Dictionary_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView_Dictionary.SelectedIndexChanged
        If ListView_Dictionary.SelectedItems.Count() > 0 Then
            Dim si As ListViewItem = ListView_Dictionary.SelectedItems(0)
            Dim subItem0 As String = si.SubItems(0).Text
            Dim subItem1 As String = si.SubItems(1).Text
            TextBox_Word.Text = subItem0
            TextBox_Read.Text = subItem1

        End If

    End Sub
    Private Sub addToDictionary()
        '辞書項目追加
        Dim newKey As String
        Dim NewValue As String

        newKey = TextBox_Word.Text
        NewValue = TextBox_Read.Text
        If newKey.Length > 0 Then
            Dim i As Integer = My.Settings.TransKey.IndexOf(newKey)
            If i >= 0 Then
                My.Settings.TransKey.RemoveAt(i)
                My.Settings.TransValue.RemoveAt(i)
            End If
            My.Settings.TransKey.Add(newKey)
            My.Settings.TransValue.Add(NewValue)

        End If
        listUpdate()
        My.Settings.Save()
    End Sub

    Private Sub Button_Add_Click(sender As Object, e As EventArgs) Handles Button_Add.Click
        addToDictionary()
    End Sub

    Private Sub Button_Remove_Click(sender As Object, e As EventArgs) Handles Button_Remove.Click
        '辞書項目削除
        For Each si As ListViewItem In ListView_Dictionary.SelectedItems
            Dim key As String = si.SubItems(0).Text
            Dim subItem1 As String = si.SubItems(1).Text
            Dim i As Integer = My.Settings.TransKey.IndexOf(key)
            If i >= 0 Then
                My.Settings.TransKey.RemoveAt(i)
                My.Settings.TransValue.RemoveAt(i)
            End If


        Next
        listUpdate()
        My.Settings.Save()
    End Sub

    Private Sub CheckBox_SpeedUp_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_SpeedUp.CheckedChanged
        My.Settings.AutoSpeed = CheckBox_SpeedUp.Checked
    End Sub

    Private Sub CheckBox_DontReadNG_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_DontReadNG.CheckedChanged
        My.Settings.IgnoreNGuser = CheckBox_DontReadNG.Checked
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub CheckBox_ReadName_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_ReadName.CheckedChanged
        My.Settings.TalkName = CheckBox_ReadName.Checked
    End Sub

    Private Sub CheckBox_Limit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Limi.CheckedChanged
        My.Settings.IsLimit = CheckBox_Limi.Checked
        limitRefresh()

    End Sub

    Private Sub TextBox_Limit_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Limit.TextChanged
        Dim d As Integer
        If UInt32.TryParse(TextBox_Limit.Text, d) = False Then TextBox_Limit.Text = My.Settings.Length.ToString
        My.Settings.Length = UInt32.Parse(TextBox_Limit.Text)
    End Sub

    Private Sub TextBox_Suffix_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Suffix.TextChanged
        My.Settings.Suffix = TextBox_Suffix.Text
    End Sub


    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox_Multi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Multi.CheckedChanged
        My.Settings.MultiLang = CheckBox_Multi.Checked
        langRefresh()
    End Sub

    Private Sub CheckBox_En_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_En.CheckedChanged
        My.Settings.UseEnglish = CheckBox_En.Checked
    End Sub

    Private Sub CheckBox_Ko_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Ko.CheckedChanged
        My.Settings.UseKorean = CheckBox_Ko.Checked
    End Sub

    Private Sub CheckBox_HoldChannel0_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Zh.CheckedChanged
        My.Settings.UseChinese = CheckBox_Zh.Checked
    End Sub

    Private Sub CheckBox_HoldChannel1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_NameOpt.CheckedChanged
        My.Settings.ForceJAName = CheckBox_NameOpt.Checked
    End Sub

    Private Sub Button_SaveDict_Click_1(sender As Object, e As EventArgs) Handles Button_SaveDict.Click
        Dim std As New SaveFileDialog()
        std.FileName = "発音辞書.txt"
        std.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
        std.FilterIndex = 1
        std.Title = "保存先のファイルを選択してください"
        std.RestoreDirectory = True
        If std.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sw As New StreamWriter(std.FileName, False, System.Text.Encoding.UTF8)
            Dim item = My.Settings.TransKey.Count
            For i As Integer = 0 To item - 1
                sw.Write(My.Settings.TransKey(i))
                sw.Write(ControlChars.Tab)
                sw.Write(My.Settings.TransValue(i))
                sw.Write(ControlChars.CrLf)
            Next
            sw.Close()
        End If
    End Sub

    Private Sub Button_ReadDict_Click(sender As Object, e As EventArgs) Handles Button_ReadDict.Click
        Dim ofd As New OpenFileDialog()
        ofd.FileName = "発音辞書.txt"
        ofd.Filter = "テキストファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*"
        ofd.Title = "辞書ファイルを選択してください。辞書の内容は置き換えられます"
        ofd.FilterIndex = 1
        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim sr As New StreamReader(ofd.FileName, System.Text.Encoding.UTF8, True)
            My.Settings.TransKey.Clear()
            My.Settings.TransValue.Clear()
            While (sr.Peek() >= 0)
                Dim line As String = sr.ReadLine()
                Dim ar As String() = line.Split(ControlChars.Tab)
                If ar.Length > 1 Then
                    My.Settings.TransKey.Add(ar(0))
                    My.Settings.TransValue.Add(ar(1))
                ElseIf ar.Length = 1 Then
                    My.Settings.TransKey.Add(ar(0))
                    My.Settings.TransValue.Add("")
                End If
            End While
            listUpdate()
        End If

    End Sub

    Private Sub TextBox_Read_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Read.TextChanged

    End Sub

    Private Sub TextBox_Read_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Read.KeyPress

        If e.KeyChar = Chr(Keys.Enter) Then
            addToDictionary()
            e.Handled = True
        End If

    End Sub

    Private Sub TextBox_Word_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_Word.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            addToDictionary()
            e.Handled = True
        End If
    End Sub

    Private Sub ComboBox_Japanese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Japanese.SelectedIndexChanged
        My.Settings.JAvoice = ComboBox_Japanese.SelectedItem
    End Sub

    Private Sub ComboBox_English_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_English.SelectedIndexChanged
        My.Settings.ENvoice = ComboBox_English.SelectedItem
    End Sub

    Private Sub ComboBox_Korean_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Korean.SelectedIndexChanged
        My.Settings.KOVoice = ComboBox_Korean.SelectedItem
    End Sub

    Private Sub ComboBox_Chinese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox_Chinese.SelectedIndexChanged
        My.Settings.ZHVoice = ComboBox_Chinese.SelectedItem
    End Sub




    Private Sub Button_Stop_Click(sender As Object, e As EventArgs) Handles Button_Stop.Click
        If skip Then

            skip = False
            Button_Stop.Text = "読み上げ停止"
        Else
            skip = True
            Button_Stop.Text = "読み上げ再開"
        End If
    End Sub

    Private Sub LinkLabel_Subscliption_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Subscliption.LinkClicked
        LinkLabel_Subscliption.LinkVisited = True
        System.Diagnostics.Process.Start("https://datamarket.azure.com/dataset/1899a118-d202-492c-aa16-ba21c33c06cb")
    End Sub

    Private Sub TextBox_ID_TextChanged(sender As Object, e As EventArgs) Handles TextBox_ID.TextChanged
        My.Settings.ClientID = TextBox_ID.Text
    End Sub

    Private Sub TextBox_Secret_TextChanged(sender As Object, e As EventArgs) Handles TextBox_Secret.TextChanged
        My.Settings.ClientSecret = TextBox_Secret.Text
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_UseTranslation.CheckedChanged
        My.Settings.Translate = CheckBox_UseTranslation.Checked
    End Sub

    Private Sub LinkLabel_ClientID_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_ClientID.LinkClicked
        LinkLabel_ClientID.LinkVisited = True
        System.Diagnostics.Process.Start("https://datamarket.azure.com/developer/applications")
    End Sub

    Private Sub getChannelInfo()
        Dim curChannel As String = TextBox_Channel.Text
        Dim url As String = "http://live.fc2.com/api/memberApi.php?streamid=" + curChannel + "&channel=1&profile=1"
        Dim wc As WebClient = New WebClient()
        Dim st As Stream = Nothing
        Try
            'Dim st As Stream = wc.OpenRead(url1)
            st = wc.OpenRead(url)
        Catch ex As WebException
            If st IsNot Nothing Then
                st.Close()

            End If
            Return
        End Try

        Dim enc As Encoding = Encoding.GetEncoding("utf-8")
        Dim sr As StreamReader = New StreamReader(st, enc)
        Dim html As String = sr.ReadToEnd()
        sr.Close()

        st.Close()
        Try


            Dim js As Object = JsonConvert.DeserializeObject(html)

            If js("status") = 1 Then
                Dim title As String = js("data")("channel_data")("title")
                Dim name As String = js("data")("profile_data")("name")
                If Label_title.Text <> title Then
                    WriteCommentLog("■■■■配信者:" + name)
                    WriteCommentLog("■■■■タイトル:" + title)
                    logBlock = False
                End If
                Label_count.Text = js("data")("channel_data")("count").ToString
                Label_title.Text = title
                Label_name.Text = name
                TextBox_info.Text = js("data")("channel_data")("info").ToString().Replace(Chr(10), vbCrLf)
                PictureBox1.ImageLocation = js("data")("channel_data")("image")
                Label_start.Text = js("data")("channel_data")("start")

                If js("data")("channel_data")("is_publish") Then
                    Label_onair.Text = "配信中"
                    Label_onair.BackColor = System.Drawing.Color.Red
                    Label_onair.ForeColor = System.Drawing.Color.Yellow
                Else
                    Label_onair.Text = "配信していません"
                    Label_onair.BackColor = System.Drawing.Color.Transparent
                    Label_onair.ForeColor = System.Drawing.Color.Black
                End If
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Interval = 60000
        getChannelInfo()


    End Sub

    Private Sub コピーToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles コピーToolStripMenuItem.Click
        Dim result As String = ""
        For Each si As ListViewItem In ListView_Comment.SelectedItems
            Dim name As String = si.SubItems(0).Text
            Dim comment As String = si.SubItems(1).Text
            result = result + name + ControlChars.Tab + comment + ControlChars.NewLine
        Next
        If result.Length > 0 Then
            Clipboard.SetText(result)
        End If
    End Sub

    Private Sub CheckBox_Bouyomi_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox_Bouyomi.CheckedChanged
        My.Settings.Bouyomi = CheckBox_Bouyomi.Checked
        If CheckBox_Bouyomi.Checked Then
            ComboBox_Japanese.Enabled = False
        Else
            ComboBox_Japanese.Enabled = True
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        LinkLabel_ClientID.LinkVisited = True
        System.Diagnostics.Process.Start("http://chi.usamimi.info/Program/Application/BouyomiChan/")
    End Sub
End Class
