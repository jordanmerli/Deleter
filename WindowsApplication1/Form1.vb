Public Class Form1
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Red
        Me.TextBox1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(7, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 21)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Percorso:"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(155, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 30)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "&Cerca..."
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.Description = "Browse..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(148, 50)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cancella"
        '
        'RadioButton2
        '
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(68, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(74, 24)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.Text = "&Cartella"
        '
        'RadioButton1
        '
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.RadioButton1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(6, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 24)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "&File"
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(279, 15)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(57, 30)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Crediti"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label2.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(216, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 42)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Jordan Merli " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Production"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Calibri", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.OrangeRed
        Me.Label3.Location = New System.Drawing.Point(45, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(293, 30)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Attenzione! Cliccando il tasto qui sotto il file o la cartella selezionato/a verr" & _
    "à cancellato/a definitivamente senza passare dal cestino."
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.Deleter.My.Resources.Resources.App_error
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(12, 98)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(27, 27)
        Me.Panel1.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(7, 131)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(329, 25)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "&Cancella!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 16)
        Me.ClientSize = New System.Drawing.Size(341, 157)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Opacity = 0.9R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Directory Or File by Jordan"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Filter = "Tutti i file (*.*)|*.*"
        If RadioButton1.Checked = True Then
            OpenFileDialog1.ShowDialog()
            TextBox1.Text = OpenFileDialog1.FileName
        Else
            FolderBrowserDialog1.ShowDialog()
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Select Case RadioButton1.CausesValidation And RadioButton2.CausesValidation
            Case RadioButton1.Checked = False And RadioButton2.Checked = False
                MsgBox("Scegli Un Opzione!", MsgBoxStyle.Exclamation, "Error")
            Case RadioButton1.Checked = True And RadioButton2.Checked = False
                If TextBox1.Text = "" Then
                    MsgBox("Non è stato specificato nessun percorso! Selezionare prima cosa cancellare.", MsgBoxStyle.Critical, "Attenzione!")
                Else
                    Kill(TextBox1.Text)
                End If
            Case RadioButton1.Checked = False And RadioButton2.Checked = True
                If TextBox1.Text = "" Then
                    MsgBox("Non è stato specificato nessun percorso! Selezionare prima cosa cancellare.", MsgBoxStyle.Critical, "Attenzione!")
                Else
                    DelTree(TextBox1.Text)
                End If
        End Select
    End Sub
    Private Sub DelTree(ByVal SFolder As String)
        Dim sCurrFile As String
        sCurrFile = Dir(SFolder & "\*.*", vbDirectory)
        Do While Len(sCurrFile) > 0
            If sCurrFile <> "." And sCurrFile <> ".." Then
                If (GetAttr(SFolder & "\" & sCurrFile) And vbDirectory) = _
                vbDirectory Then
                    Call DelTree(SFolder & "\" & sCurrFile)
                    sCurrFile = Dir(SFolder & "\*.*", vbDirectory)
                Else
                    Kill(SFolder & "\" & sCurrFile)
                    sCurrFile = Dir()
                End If
            Else
                sCurrFile = Dir()
            End If
        Loop
        RmDir(SFolder)
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.Show()
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.BackColor = Color.Chartreuse
            Button2.Enabled = True
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            TextBox1.BackColor = Color.Chartreuse
            Button2.Enabled = True
        End If
    End Sub
    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Select Case RadioButton1.CausesValidation And RadioButton2.CausesValidation
            Case RadioButton1.Checked = False And RadioButton2.Checked = False
                MsgBox("Scegli Un Opzione!", MsgBoxStyle.Exclamation, "Error")
            Case RadioButton1.Checked = True And RadioButton2.Checked = False
                If TextBox1.Text = "" Then
                    MsgBox("Non è stato specificato nessun percorso! Selezionare prima cosa cancellare.", MsgBoxStyle.Critical, "Attenzione!")
                Else
                    Kill(TextBox1.Text)
                    TextBox1.Text = ""
                End If
            Case RadioButton1.Checked = False And RadioButton2.Checked = True
                If TextBox1.Text = "" Then
                    MsgBox("Non è stato specificato nessun percorso! Selezionare prima cosa cancellare.", MsgBoxStyle.Critical, "Attenzione!")
                Else
                    DelTree(TextBox1.Text)
                    TextBox1.Text = ""
                End If
        End Select
    End Sub
End Class
