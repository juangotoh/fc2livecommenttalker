<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ListView_Comment = New System.Windows.Forms.ListView()
        Me.名前 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.コメント = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.コピーToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button_Stop = New System.Windows.Forms.Button()
        Me.Label_Time = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox_En = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Ko = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Multi = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Zh = New System.Windows.Forms.CheckBox()
        Me.CheckBox_NameOpt = New System.Windows.Forms.CheckBox()
        Me.TextBox_Word = New System.Windows.Forms.TextBox()
        Me.TextBox_Read = New System.Windows.Forms.TextBox()
        Me.Button_Add = New System.Windows.Forms.Button()
        Me.Button_Remove = New System.Windows.Forms.Button()
        Me.ListView_Dictionary = New System.Windows.Forms.ListView()
        Me.key = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.value = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button_SaveDict = New System.Windows.Forms.Button()
        Me.Button_ReadDict = New System.Windows.Forms.Button()
        Me.TrackBar_Volume = New System.Windows.Forms.TrackBar()
        Me.TextBox_Channel = New System.Windows.Forms.TextBox()
        Me.CheckBox_SpeedUp = New System.Windows.Forms.CheckBox()
        Me.CheckBox_DontReadNG = New System.Windows.Forms.CheckBox()
        Me.CheckBox_ReadName = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Limi = New System.Windows.Forms.CheckBox()
        Me.TextBox_Suffix = New System.Windows.Forms.TextBox()
        Me.CheckBox_UseTranslation = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Bouyomi = New System.Windows.Forms.CheckBox()
        Me.CheckBox_Async = New System.Windows.Forms.CheckBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox_Secret = New System.Windows.Forms.TextBox()
        Me.TextBox_ID = New System.Windows.Forms.TextBox()
        Me.LinkLabel_ClientID = New System.Windows.Forms.LinkLabel()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.LinkLabel_Subscliption = New System.Windows.Forms.LinkLabel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.ComboBox_Chinese = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Korean = New System.Windows.Forms.ComboBox()
        Me.ComboBox_English = New System.Windows.Forms.ComboBox()
        Me.ComboBox_Japanese = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label_onair = New System.Windows.Forms.Label()
        Me.TextBox_info = New System.Windows.Forms.TextBox()
        Me.TextBox_Limit = New System.Windows.Forms.TextBox()
        Me.Label_start = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label_title = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label_name = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label_count = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_Speed = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox_HoldChannel = New System.Windows.Forms.CheckBox()
        Me.Label_Volume = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.ContextMenuStrip1.SuspendLayout()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'ListView_Comment
        '
        Me.ListView_Comment.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListView_Comment.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.名前, Me.コメント})
        Me.ListView_Comment.ContextMenuStrip = Me.ContextMenuStrip1
        Me.ListView_Comment.FullRowSelect = True
        Me.ListView_Comment.LabelEdit = True
        Me.ListView_Comment.Location = New System.Drawing.Point(2, 284)
        Me.ListView_Comment.Name = "ListView_Comment"
        Me.ListView_Comment.Size = New System.Drawing.Size(509, 181)
        Me.ListView_Comment.TabIndex = 35
        Me.ListView_Comment.UseCompatibleStateImageBehavior = False
        Me.ListView_Comment.View = System.Windows.Forms.View.Details
        '
        '名前
        '
        Me.名前.Text = "名前"
        Me.名前.Width = 120
        '
        'コメント
        '
        Me.コメント.Text = "コメント"
        Me.コメント.Width = 600
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.コピーToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(120, 26)
        '
        'コピーToolStripMenuItem
        '
        Me.コピーToolStripMenuItem.Name = "コピーToolStripMenuItem"
        Me.コピーToolStripMenuItem.Size = New System.Drawing.Size(119, 22)
        Me.コピーToolStripMenuItem.Text = "コピー(&C)"
        '
        'Button_Stop
        '
        Me.Button_Stop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Stop.Location = New System.Drawing.Point(415, 471)
        Me.Button_Stop.Name = "Button_Stop"
        Me.Button_Stop.Size = New System.Drawing.Size(96, 23)
        Me.Button_Stop.TabIndex = 34
        Me.Button_Stop.Text = "読み上げ停止"
        Me.ToolTip1.SetToolTip(Me.Button_Stop, "読み上げを停止します。もう一度クリックすると再開します")
        Me.Button_Stop.UseVisualStyleBackColor = True
        '
        'Label_Time
        '
        Me.Label_Time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label_Time.AutoSize = True
        Me.Label_Time.Location = New System.Drawing.Point(89, 476)
        Me.Label_Time.Name = "Label_Time"
        Me.Label_Time.Size = New System.Drawing.Size(17, 12)
        Me.Label_Time.TabIndex = 33
        Me.Label_Time.Text = "   "
        Me.ToolTip1.SetToolTip(Me.Label_Time, "最後に発言されたコメントの時刻です")
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(4, 477)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 12)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "最新発言時刻:"
        '
        'CheckBox_En
        '
        Me.CheckBox_En.AutoSize = True
        Me.CheckBox_En.Location = New System.Drawing.Point(40, 143)
        Me.CheckBox_En.Name = "CheckBox_En"
        Me.CheckBox_En.Size = New System.Drawing.Size(50, 16)
        Me.CheckBox_En.TabIndex = 1
        Me.CheckBox_En.Text = "英語:"
        Me.ToolTip1.SetToolTip(Me.CheckBox_En, "英語の読み上げを有効にします")
        Me.CheckBox_En.UseVisualStyleBackColor = True
        '
        'CheckBox_Ko
        '
        Me.CheckBox_Ko.AutoSize = True
        Me.CheckBox_Ko.Location = New System.Drawing.Point(40, 169)
        Me.CheckBox_Ko.Name = "CheckBox_Ko"
        Me.CheckBox_Ko.Size = New System.Drawing.Size(62, 16)
        Me.CheckBox_Ko.TabIndex = 2
        Me.CheckBox_Ko.Text = "韓国語:"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Ko, "韓国語の読み上げを有効にします")
        Me.CheckBox_Ko.UseVisualStyleBackColor = True
        '
        'CheckBox_Multi
        '
        Me.CheckBox_Multi.AutoSize = True
        Me.CheckBox_Multi.Location = New System.Drawing.Point(18, 123)
        Me.CheckBox_Multi.Name = "CheckBox_Multi"
        Me.CheckBox_Multi.Size = New System.Drawing.Size(84, 16)
        Me.CheckBox_Multi.TabIndex = 0
        Me.CheckBox_Multi.Text = "多言語対応"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Multi, "日本語以外に英語、韓国語、中国語を読み分けます")
        Me.CheckBox_Multi.UseVisualStyleBackColor = True
        '
        'CheckBox_Zh
        '
        Me.CheckBox_Zh.AutoSize = True
        Me.CheckBox_Zh.Location = New System.Drawing.Point(40, 197)
        Me.CheckBox_Zh.Name = "CheckBox_Zh"
        Me.CheckBox_Zh.Size = New System.Drawing.Size(62, 16)
        Me.CheckBox_Zh.TabIndex = 3
        Me.CheckBox_Zh.Text = "中国語:"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Zh, "中国語の読み上げを有効にします")
        Me.CheckBox_Zh.UseVisualStyleBackColor = True
        '
        'CheckBox_NameOpt
        '
        Me.CheckBox_NameOpt.AutoSize = True
        Me.CheckBox_NameOpt.Location = New System.Drawing.Point(117, 221)
        Me.CheckBox_NameOpt.Name = "CheckBox_NameOpt"
        Me.CheckBox_NameOpt.Size = New System.Drawing.Size(130, 16)
        Me.CheckBox_NameOpt.TabIndex = 5
        Me.CheckBox_NameOpt.Text = "名前欄は中国語無効"
        Me.ToolTip1.SetToolTip(Me.CheckBox_NameOpt, "名前欄では中国語読みをしません")
        Me.CheckBox_NameOpt.UseVisualStyleBackColor = True
        '
        'TextBox_Word
        '
        Me.TextBox_Word.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Word.Location = New System.Drawing.Point(353, 6)
        Me.TextBox_Word.Name = "TextBox_Word"
        Me.TextBox_Word.Size = New System.Drawing.Size(125, 19)
        Me.TextBox_Word.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.TextBox_Word, "単語を入力します")
        '
        'TextBox_Read
        '
        Me.TextBox_Read.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Read.Location = New System.Drawing.Point(353, 31)
        Me.TextBox_Read.Name = "TextBox_Read"
        Me.TextBox_Read.Size = New System.Drawing.Size(125, 19)
        Me.TextBox_Read.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.TextBox_Read, "よみがなを入力します")
        '
        'Button_Add
        '
        Me.Button_Add.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Add.Location = New System.Drawing.Point(354, 56)
        Me.Button_Add.Name = "Button_Add"
        Me.Button_Add.Size = New System.Drawing.Size(84, 23)
        Me.Button_Add.TabIndex = 5
        Me.Button_Add.Text = "追加/変更"
        Me.ToolTip1.SetToolTip(Me.Button_Add, "単語と読みを辞書に追加します")
        Me.Button_Add.UseVisualStyleBackColor = True
        '
        'Button_Remove
        '
        Me.Button_Remove.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_Remove.Location = New System.Drawing.Point(353, 85)
        Me.Button_Remove.Name = "Button_Remove"
        Me.Button_Remove.Size = New System.Drawing.Size(85, 23)
        Me.Button_Remove.TabIndex = 7
        Me.Button_Remove.Text = "削除"
        Me.ToolTip1.SetToolTip(Me.Button_Remove, "選択した単語を辞書から削除します")
        Me.Button_Remove.UseVisualStyleBackColor = True
        '
        'ListView_Dictionary
        '
        Me.ListView_Dictionary.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ListView_Dictionary.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.key, Me.value})
        Me.ListView_Dictionary.GridLines = True
        Me.ListView_Dictionary.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView_Dictionary.HideSelection = False
        Me.ListView_Dictionary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ListView_Dictionary.Location = New System.Drawing.Point(6, 6)
        Me.ListView_Dictionary.MultiSelect = False
        Me.ListView_Dictionary.Name = "ListView_Dictionary"
        Me.ListView_Dictionary.Size = New System.Drawing.Size(307, 239)
        Me.ListView_Dictionary.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.ListView_Dictionary, "思ったように読まれない単語の読み方を指定します")
        Me.ListView_Dictionary.UseCompatibleStateImageBehavior = False
        Me.ListView_Dictionary.View = System.Windows.Forms.View.Details
        '
        'key
        '
        Me.key.Text = "単語"
        Me.key.Width = 151
        '
        'value
        '
        Me.value.Text = "読み"
        Me.value.Width = 152
        '
        'Button_SaveDict
        '
        Me.Button_SaveDict.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_SaveDict.Location = New System.Drawing.Point(353, 193)
        Me.Button_SaveDict.Name = "Button_SaveDict"
        Me.Button_SaveDict.Size = New System.Drawing.Size(85, 23)
        Me.Button_SaveDict.TabIndex = 9
        Me.Button_SaveDict.Text = "辞書保存"
        Me.ToolTip1.SetToolTip(Me.Button_SaveDict, "辞書をテキストファイルに書き出します")
        Me.Button_SaveDict.UseVisualStyleBackColor = True
        '
        'Button_ReadDict
        '
        Me.Button_ReadDict.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button_ReadDict.Location = New System.Drawing.Point(353, 222)
        Me.Button_ReadDict.Name = "Button_ReadDict"
        Me.Button_ReadDict.Size = New System.Drawing.Size(85, 23)
        Me.Button_ReadDict.TabIndex = 10
        Me.Button_ReadDict.Text = "辞書読み込み"
        Me.ToolTip1.SetToolTip(Me.Button_ReadDict, "辞書ファイルを読み込んで現在の辞書と置き換えます")
        Me.Button_ReadDict.UseVisualStyleBackColor = True
        '
        'TrackBar_Volume
        '
        Me.TrackBar_Volume.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrackBar_Volume.BackColor = System.Drawing.SystemColors.Window
        Me.TrackBar_Volume.LargeChange = 10
        Me.TrackBar_Volume.Location = New System.Drawing.Point(392, 191)
        Me.TrackBar_Volume.Maximum = 100
        Me.TrackBar_Volume.Name = "TrackBar_Volume"
        Me.TrackBar_Volume.Size = New System.Drawing.Size(103, 45)
        Me.TrackBar_Volume.TabIndex = 8
        Me.TrackBar_Volume.TickFrequency = 10
        Me.ToolTip1.SetToolTip(Me.TrackBar_Volume, "音量を調整します")
        '
        'TextBox_Channel
        '
        Me.TextBox_Channel.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.TextBox_Channel.Location = New System.Drawing.Point(105, 10)
        Me.TextBox_Channel.Name = "TextBox_Channel"
        Me.TextBox_Channel.Size = New System.Drawing.Size(140, 19)
        Me.TextBox_Channel.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.TextBox_Channel, "配信URL ""http://live.fc2.com/********/"" の、********の部分")
        '
        'CheckBox_SpeedUp
        '
        Me.CheckBox_SpeedUp.AutoSize = True
        Me.CheckBox_SpeedUp.Location = New System.Drawing.Point(14, 180)
        Me.CheckBox_SpeedUp.Name = "CheckBox_SpeedUp"
        Me.CheckBox_SpeedUp.Size = New System.Drawing.Size(216, 16)
        Me.CheckBox_SpeedUp.TabIndex = 23
        Me.CheckBox_SpeedUp.Text = "コメントが多い時、読み上げスピードアップ"
        Me.ToolTip1.SetToolTip(Me.CheckBox_SpeedUp, "一度に多くのコメントが来た時など、早口で読み上げます")
        Me.CheckBox_SpeedUp.UseVisualStyleBackColor = True
        '
        'CheckBox_DontReadNG
        '
        Me.CheckBox_DontReadNG.AutoSize = True
        Me.CheckBox_DontReadNG.Location = New System.Drawing.Point(14, 202)
        Me.CheckBox_DontReadNG.Name = "CheckBox_DontReadNG"
        Me.CheckBox_DontReadNG.Size = New System.Drawing.Size(209, 16)
        Me.CheckBox_DontReadNG.TabIndex = 24
        Me.CheckBox_DontReadNG.Text = "NGコメントのユーザー名を読み上げない"
        Me.ToolTip1.SetToolTip(Me.CheckBox_DontReadNG, "NGユーザー、NGコメントの場合読み上げません。")
        Me.CheckBox_DontReadNG.UseVisualStyleBackColor = True
        '
        'CheckBox_ReadName
        '
        Me.CheckBox_ReadName.AutoSize = True
        Me.CheckBox_ReadName.Location = New System.Drawing.Point(14, 158)
        Me.CheckBox_ReadName.Name = "CheckBox_ReadName"
        Me.CheckBox_ReadName.Size = New System.Drawing.Size(79, 16)
        Me.CheckBox_ReadName.TabIndex = 27
        Me.CheckBox_ReadName.Text = "名前も読む"
        Me.ToolTip1.SetToolTip(Me.CheckBox_ReadName, "コメントの前にユーザーの名前を読みます")
        Me.CheckBox_ReadName.UseVisualStyleBackColor = True
        '
        'CheckBox_Limi
        '
        Me.CheckBox_Limi.AutoSize = True
        Me.CheckBox_Limi.Location = New System.Drawing.Point(14, 224)
        Me.CheckBox_Limi.Name = "CheckBox_Limi"
        Me.CheckBox_Limi.Size = New System.Drawing.Size(86, 16)
        Me.CheckBox_Limi.TabIndex = 28
        Me.CheckBox_Limi.Text = "文字数制限:"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Limi, "設定した文字数で読み上げを切ります")
        Me.CheckBox_Limi.UseVisualStyleBackColor = True
        '
        'TextBox_Suffix
        '
        Me.TextBox_Suffix.Location = New System.Drawing.Point(214, 221)
        Me.TextBox_Suffix.Name = "TextBox_Suffix"
        Me.TextBox_Suffix.Size = New System.Drawing.Size(96, 19)
        Me.TextBox_Suffix.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.TextBox_Suffix, "コメントを短縮した時に末尾で読ませる言葉")
        '
        'CheckBox_UseTranslation
        '
        Me.CheckBox_UseTranslation.AutoSize = True
        Me.CheckBox_UseTranslation.Location = New System.Drawing.Point(22, 26)
        Me.CheckBox_UseTranslation.Name = "CheckBox_UseTranslation"
        Me.CheckBox_UseTranslation.Size = New System.Drawing.Size(169, 16)
        Me.CheckBox_UseTranslation.TabIndex = 8
        Me.CheckBox_UseTranslation.Text = "外国語コメントを自動翻訳する"
        Me.ToolTip1.SetToolTip(Me.CheckBox_UseTranslation, "外国語のコメントを日本語に翻訳します。")
        Me.CheckBox_UseTranslation.UseVisualStyleBackColor = True
        '
        'CheckBox_Bouyomi
        '
        Me.CheckBox_Bouyomi.AutoSize = True
        Me.CheckBox_Bouyomi.Location = New System.Drawing.Point(110, 49)
        Me.CheckBox_Bouyomi.Name = "CheckBox_Bouyomi"
        Me.CheckBox_Bouyomi.Size = New System.Drawing.Size(219, 16)
        Me.CheckBox_Bouyomi.TabIndex = 9
        Me.CheckBox_Bouyomi.Text = "日本語の読み上げに棒読みちゃんを使用"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Bouyomi, "外部アプリケーションの「棒読みちゃん」を使って日本語を読み上げます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "あらかじめ棒読みちゃんを起動しておく必要があります。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "棒読みちゃん使用時は非同期読み上げ" & _
        "、自動加速の設定は無効です。")
        Me.CheckBox_Bouyomi.UseVisualStyleBackColor = True
        '
        'CheckBox_Async
        '
        Me.CheckBox_Async.AutoSize = True
        Me.CheckBox_Async.Location = New System.Drawing.Point(161, 158)
        Me.CheckBox_Async.Name = "CheckBox_Async"
        Me.CheckBox_Async.Size = New System.Drawing.Size(105, 16)
        Me.CheckBox_Async.TabIndex = 49
        Me.CheckBox_Async.Text = "非同期読み上げ"
        Me.ToolTip1.SetToolTip(Me.CheckBox_Async, "読み終わるのを待たず次のコメントを読みます。")
        Me.CheckBox_Async.UseVisualStyleBackColor = True
        '
        'Timer2
        '
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.Label19)
        Me.TabPage5.Controls.Add(Me.CheckBox_UseTranslation)
        Me.TabPage5.Controls.Add(Me.TextBox_Secret)
        Me.TabPage5.Controls.Add(Me.TextBox_ID)
        Me.TabPage5.Controls.Add(Me.LinkLabel_ClientID)
        Me.TabPage5.Controls.Add(Me.Label18)
        Me.TabPage5.Controls.Add(Me.Label17)
        Me.TabPage5.Controls.Add(Me.Label16)
        Me.TabPage5.Controls.Add(Me.LinkLabel_Subscliption)
        Me.TabPage5.Controls.Add(Me.Label15)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(501, 251)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "翻訳"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(20, 86)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(285, 12)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "無料のサブスクリプションで月間200万文字まで翻訳できます"
        '
        'TextBox_Secret
        '
        Me.TextBox_Secret.Location = New System.Drawing.Point(95, 214)
        Me.TextBox_Secret.Name = "TextBox_Secret"
        Me.TextBox_Secret.Size = New System.Drawing.Size(307, 19)
        Me.TextBox_Secret.TabIndex = 7
        '
        'TextBox_ID
        '
        Me.TextBox_ID.Location = New System.Drawing.Point(95, 169)
        Me.TextBox_ID.Name = "TextBox_ID"
        Me.TextBox_ID.Size = New System.Drawing.Size(307, 19)
        Me.TextBox_ID.TabIndex = 6
        '
        'LinkLabel_ClientID
        '
        Me.LinkLabel_ClientID.AutoSize = True
        Me.LinkLabel_ClientID.Location = New System.Drawing.Point(310, 115)
        Me.LinkLabel_ClientID.Name = "LinkLabel_ClientID"
        Me.LinkLabel_ClientID.Size = New System.Drawing.Size(128, 12)
        Me.LinkLabel_ClientID.TabIndex = 5
        Me.LinkLabel_ClientID.TabStop = True
        Me.LinkLabel_ClientID.Text = "アプリケーション登録ページ"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(19, 115)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(262, 12)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "購入後以下のページでクライアントＩＤを設定してください"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(20, 221)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 12)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "顧客の秘密:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(20, 172)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 12)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "クライアントID:"
        '
        'LinkLabel_Subscliption
        '
        Me.LinkLabel_Subscliption.AutoSize = True
        Me.LinkLabel_Subscliption.Location = New System.Drawing.Point(310, 86)
        Me.LinkLabel_Subscliption.Name = "LinkLabel_Subscliption"
        Me.LinkLabel_Subscliption.Size = New System.Drawing.Size(181, 12)
        Me.LinkLabel_Subscliption.TabIndex = 1
        Me.LinkLabel_Subscliption.TabStop = True
        Me.LinkLabel_Subscliption.Text = "Windows Azule Marketplaceで購入"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(20, 63)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(232, 12)
        Me.Label15.TabIndex = 0
        Me.Label15.Text = "Microsoft Translatorを購入する必要があります"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Label12)
        Me.TabPage4.Controls.Add(Me.CheckBox_NameOpt)
        Me.TabPage4.Controls.Add(Me.LinkLabel1)
        Me.TabPage4.Controls.Add(Me.CheckBox_Zh)
        Me.TabPage4.Controls.Add(Me.CheckBox_Multi)
        Me.TabPage4.Controls.Add(Me.CheckBox_Bouyomi)
        Me.TabPage4.Controls.Add(Me.ComboBox_Chinese)
        Me.TabPage4.Controls.Add(Me.CheckBox_Ko)
        Me.TabPage4.Controls.Add(Me.ComboBox_Korean)
        Me.TabPage4.Controls.Add(Me.CheckBox_En)
        Me.TabPage4.Controls.Add(Me.ComboBox_English)
        Me.TabPage4.Controls.Add(Me.ComboBox_Japanese)
        Me.TabPage4.Controls.Add(Me.Label11)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(501, 251)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "音声"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(133, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(225, 24)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Windowsのテキスト読み上げ機能の代わりに、" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "日本語の読み上げに棒読みちゃんを使います。"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(364, 80)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(103, 12)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "棒読みちゃん配布元"
        '
        'ComboBox_Chinese
        '
        Me.ComboBox_Chinese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Chinese.DropDownWidth = 512
        Me.ComboBox_Chinese.FormattingEnabled = True
        Me.ComboBox_Chinese.Location = New System.Drawing.Point(107, 190)
        Me.ComboBox_Chinese.Name = "ComboBox_Chinese"
        Me.ComboBox_Chinese.Size = New System.Drawing.Size(366, 20)
        Me.ComboBox_Chinese.TabIndex = 7
        '
        'ComboBox_Korean
        '
        Me.ComboBox_Korean.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Korean.FormattingEnabled = True
        Me.ComboBox_Korean.Location = New System.Drawing.Point(107, 164)
        Me.ComboBox_Korean.Name = "ComboBox_Korean"
        Me.ComboBox_Korean.Size = New System.Drawing.Size(366, 20)
        Me.ComboBox_Korean.TabIndex = 5
        '
        'ComboBox_English
        '
        Me.ComboBox_English.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_English.FormattingEnabled = True
        Me.ComboBox_English.Location = New System.Drawing.Point(107, 138)
        Me.ComboBox_English.Name = "ComboBox_English"
        Me.ComboBox_English.Size = New System.Drawing.Size(365, 20)
        Me.ComboBox_English.TabIndex = 3
        '
        'ComboBox_Japanese
        '
        Me.ComboBox_Japanese.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox_Japanese.FormattingEnabled = True
        Me.ComboBox_Japanese.Location = New System.Drawing.Point(85, 18)
        Me.ComboBox_Japanese.Name = "ComboBox_Japanese"
        Me.ComboBox_Japanese.Size = New System.Drawing.Size(365, 20)
        Me.ComboBox_Japanese.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 12)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "日本語:"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Button_ReadDict)
        Me.TabPage2.Controls.Add(Me.Button_SaveDict)
        Me.TabPage2.Controls.Add(Me.ListView_Dictionary)
        Me.TabPage2.Controls.Add(Me.TextBox_Read)
        Me.TabPage2.Controls.Add(Me.TextBox_Word)
        Me.TabPage2.Controls.Add(Me.Button_Remove)
        Me.TabPage2.Controls.Add(Me.Button_Add)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(501, 251)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "辞書"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(317, 31)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(30, 12)
        Me.Label21.TabIndex = 12
        Me.Label21.Text = "読み:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(316, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 12)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "単語:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(173, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 12)
        Me.Label6.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.CheckBox_Async)
        Me.TabPage1.Controls.Add(Me.Label_onair)
        Me.TabPage1.Controls.Add(Me.TextBox_info)
        Me.TabPage1.Controls.Add(Me.TextBox_Suffix)
        Me.TabPage1.Controls.Add(Me.TextBox_Limit)
        Me.TabPage1.Controls.Add(Me.TextBox_Channel)
        Me.TabPage1.Controls.Add(Me.Label_start)
        Me.TabPage1.Controls.Add(Me.Label20)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label_title)
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.Label_name)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label_count)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.CheckBox_Limi)
        Me.TabPage1.Controls.Add(Me.CheckBox_ReadName)
        Me.TabPage1.Controls.Add(Me.Label_Speed)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.CheckBox_DontReadNG)
        Me.TabPage1.Controls.Add(Me.CheckBox_SpeedUp)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.CheckBox_HoldChannel)
        Me.TabPage1.Controls.Add(Me.Label_Volume)
        Me.TabPage1.Controls.Add(Me.TrackBar_Volume)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(501, 251)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "メイン"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label_onair
        '
        Me.Label_onair.AutoSize = True
        Me.Label_onair.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label_onair.Location = New System.Drawing.Point(409, 14)
        Me.Label_onair.Name = "Label_onair"
        Me.Label_onair.Size = New System.Drawing.Size(86, 12)
        Me.Label_onair.TabIndex = 48
        Me.Label_onair.Text = "配信していません"
        '
        'TextBox_info
        '
        Me.TextBox_info.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_info.Location = New System.Drawing.Point(149, 62)
        Me.TextBox_info.Multiline = True
        Me.TextBox_info.Name = "TextBox_info"
        Me.TextBox_info.ReadOnly = True
        Me.TextBox_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox_info.Size = New System.Drawing.Size(346, 63)
        Me.TextBox_info.TabIndex = 47
        '
        'TextBox_Limit
        '
        Me.TextBox_Limit.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.TextBox_Limit.Location = New System.Drawing.Point(106, 221)
        Me.TextBox_Limit.Name = "TextBox_Limit"
        Me.TextBox_Limit.Size = New System.Drawing.Size(47, 19)
        Me.TextBox_Limit.TabIndex = 29
        '
        'Label_start
        '
        Me.Label_start.AutoSize = True
        Me.Label_start.Location = New System.Drawing.Point(97, 138)
        Me.Label_start.Name = "Label_start"
        Me.Label_start.Size = New System.Drawing.Size(13, 12)
        Me.Label_start.TabIndex = 46
        Me.Label_start.Text = "  "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(12, 138)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(79, 12)
        Me.Label20.TabIndex = 45
        Me.Label20.Text = "配信開始時刻:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(14, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(120, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'Label_title
        '
        Me.Label_title.AutoSize = True
        Me.Label_title.Location = New System.Drawing.Point(195, 47)
        Me.Label_title.Name = "Label_title"
        Me.Label_title.Size = New System.Drawing.Size(13, 12)
        Me.Label_title.TabIndex = 43
        Me.Label_title.Text = "  "
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(147, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 12)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "タイトル:"
        '
        'Label_name
        '
        Me.Label_name.AutoSize = True
        Me.Label_name.Location = New System.Drawing.Point(191, 35)
        Me.Label_name.Name = "Label_name"
        Me.Label_name.Size = New System.Drawing.Size(17, 12)
        Me.Label_name.TabIndex = 41
        Me.Label_name.Text = "   "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 12)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "配信者:"
        '
        'Label_count
        '
        Me.Label_count.AutoSize = True
        Me.Label_count.Location = New System.Drawing.Point(307, 138)
        Me.Label_count.Name = "Label_count"
        Me.Label_count.Size = New System.Drawing.Size(11, 12)
        Me.Label_count.TabIndex = 37
        Me.Label_count.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(212, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "現在の視聴者数:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(159, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 12)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "末尾追加:"
        '
        'Label_Speed
        '
        Me.Label_Speed.AutoSize = True
        Me.Label_Speed.Location = New System.Drawing.Point(273, 181)
        Me.Label_Speed.Name = "Label_Speed"
        Me.Label_Speed.Size = New System.Drawing.Size(11, 12)
        Me.Label_Speed.TabIndex = 26
        Me.Label_Speed.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(236, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 12)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "速度:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 12)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "現在のチャンネル:"
        '
        'CheckBox_HoldChannel
        '
        Me.CheckBox_HoldChannel.AutoSize = True
        Me.CheckBox_HoldChannel.Location = New System.Drawing.Point(251, 12)
        Me.CheckBox_HoldChannel.Name = "CheckBox_HoldChannel"
        Me.CheckBox_HoldChannel.Size = New System.Drawing.Size(140, 16)
        Me.CheckBox_HoldChannel.TabIndex = 15
        Me.CheckBox_HoldChannel.Text = "このチャンネルを固定する"
        Me.CheckBox_HoldChannel.UseVisualStyleBackColor = True
        '
        'Label_Volume
        '
        Me.Label_Volume.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label_Volume.AutoSize = True
        Me.Label_Volume.Location = New System.Drawing.Point(427, 176)
        Me.Label_Volume.Name = "Label_Volume"
        Me.Label_Volume.Size = New System.Drawing.Size(17, 12)
        Me.Label_Volume.TabIndex = 10
        Me.Label_Volume.Text = "50"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(392, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "音量"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(509, 277)
        Me.TabControl1.TabIndex = 11
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 495)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ListView_Comment)
        Me.Controls.Add(Me.Button_Stop)
        Me.Controls.Add(Me.Label_Time)
        Me.Controls.Add(Me.Label9)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Location", Global.FC2LiveCommentTalker2.My.MySettings.Default, "MyLocation", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = Global.FC2LiveCommentTalker2.My.MySettings.Default.MyLocation
        Me.MaximumSize = New System.Drawing.Size(800, 600)
        Me.MinimumSize = New System.Drawing.Size(430, 367)
        Me.Name = "Form1"
        Me.Text = "FC2Live Comment Talker2"
        Me.ContextMenuStrip1.ResumeLayout(False)
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.TabPage5.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button_Stop As System.Windows.Forms.Button
    Friend WithEvents 名前 As System.Windows.Forms.ColumnHeader
    Friend WithEvents コメント As System.Windows.Forms.ColumnHeader
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Public WithEvents Label_Time As System.Windows.Forms.Label
    Public WithEvents ListView_Comment As System.Windows.Forms.ListView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents コピーToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_UseTranslation As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox_Secret As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_ID As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel_ClientID As System.Windows.Forms.LinkLabel
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel_Subscliption As System.Windows.Forms.LinkLabel
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents CheckBox_NameOpt As System.Windows.Forms.CheckBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents CheckBox_Zh As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Multi As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_Bouyomi As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox_Chinese As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox_Ko As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox_Korean As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox_En As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox_English As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox_Japanese As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button_ReadDict As System.Windows.Forms.Button
    Friend WithEvents Button_SaveDict As System.Windows.Forms.Button
    Friend WithEvents ListView_Dictionary As System.Windows.Forms.ListView
    Friend WithEvents key As System.Windows.Forms.ColumnHeader
    Friend WithEvents value As System.Windows.Forms.ColumnHeader
    Friend WithEvents TextBox_Read As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Word As System.Windows.Forms.TextBox
    Friend WithEvents Button_Remove As System.Windows.Forms.Button
    Friend WithEvents Button_Add As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Label_onair As System.Windows.Forms.Label
    Friend WithEvents TextBox_info As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Suffix As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Limit As System.Windows.Forms.TextBox
    Public WithEvents TextBox_Channel As System.Windows.Forms.TextBox
    Friend WithEvents Label_start As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label_title As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label_name As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label_count As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Limi As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_ReadName As System.Windows.Forms.CheckBox
    Public WithEvents Label_Speed As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_DontReadNG As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox_SpeedUp As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_HoldChannel As System.Windows.Forms.CheckBox
    Friend WithEvents Label_Volume As System.Windows.Forms.Label
    Friend WithEvents TrackBar_Volume As System.Windows.Forms.TrackBar
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CheckBox_Async As System.Windows.Forms.CheckBox

End Class
