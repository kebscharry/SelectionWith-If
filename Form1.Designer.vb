<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnGreeting = New Button()
        txtCountry = New TextBox()
        lblCountry = New Label()
        SuspendLayout()
        ' 
        ' btnGreeting
        ' 
        btnGreeting.Location = New Point(277, 195)
        btnGreeting.Name = "btnGreeting"
        btnGreeting.Size = New Size(148, 99)
        btnGreeting.TabIndex = 0
        btnGreeting.Text = "Greeting"
        btnGreeting.UseVisualStyleBackColor = True
        ' 
        ' txtCountry
        ' 
        txtCountry.Location = New Point(351, 95)
        txtCountry.Name = "txtCountry"
        txtCountry.Size = New Size(227, 23)
        txtCountry.TabIndex = 1
        ' 
        ' lblCountry
        ' 
        lblCountry.AutoSize = True
        lblCountry.Location = New Point(183, 98)
        lblCountry.Name = "lblCountry"
        lblCountry.Size = New Size(128, 15)
        lblCountry.TabIndex = 2
        lblCountry.Text = "Where is your country?"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblCountry)
        Controls.Add(txtCountry)
        Controls.Add(btnGreeting)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnGreeting As Button
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents lblCountry As Label

End Class
