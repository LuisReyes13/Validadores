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
        Label1 = New Label()
        txtCP = New TextBox()
        btnAceptar = New Button()
        txtRFC = New TextBox()
        Label2 = New Label()
        cmbRegimenFiscal = New ComboBox()
        Label3 = New Label()
        Label4 = New Label()
        cmbCDFI = New ComboBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 49)
        Label1.Name = "Label1"
        Label1.Size = New Size(45, 25)
        Label1.TabIndex = 0
        Label1.Text = "C.P.:"
        ' 
        ' txtCP
        ' 
        txtCP.Location = New Point(151, 46)
        txtCP.Name = "txtCP"
        txtCP.Size = New Size(150, 31)
        txtCP.TabIndex = 1
        ' 
        ' btnAceptar
        ' 
        btnAceptar.Location = New Point(413, 342)
        btnAceptar.Name = "btnAceptar"
        btnAceptar.Size = New Size(112, 34)
        btnAceptar.TabIndex = 2
        btnAceptar.Text = "Aceptar"
        btnAceptar.UseVisualStyleBackColor = True
        ' 
        ' txtRFC
        ' 
        txtRFC.Location = New Point(151, 83)
        txtRFC.Name = "txtRFC"
        txtRFC.Size = New Size(363, 31)
        txtRFC.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(98, 86)
        Label2.Name = "Label2"
        Label2.Size = New Size(47, 25)
        Label2.TabIndex = 3
        Label2.Text = "RFC:"
        ' 
        ' cmbRegimenFiscal
        ' 
        cmbRegimenFiscal.FormattingEnabled = True
        cmbRegimenFiscal.Location = New Point(151, 120)
        cmbRegimenFiscal.Name = "cmbRegimenFiscal"
        cmbRegimenFiscal.Size = New Size(363, 33)
        cmbRegimenFiscal.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 123)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 25)
        Label3.TabIndex = 6
        Label3.Text = "Regimen Fiscal:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(30, 162)
        Label4.Name = "Label4"
        Label4.Size = New Size(115, 25)
        Label4.TabIndex = 8
        Label4.Text = "Uso de CFDI:"
        ' 
        ' cmbCDFI
        ' 
        cmbCDFI.FormattingEnabled = True
        cmbCDFI.Location = New Point(151, 159)
        cmbCDFI.Name = "cmbCDFI"
        cmbCDFI.Size = New Size(363, 33)
        cmbCDFI.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(cmbCDFI)
        Controls.Add(Label3)
        Controls.Add(cmbRegimenFiscal)
        Controls.Add(txtRFC)
        Controls.Add(Label2)
        Controls.Add(btnAceptar)
        Controls.Add(txtCP)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents txtRFC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbRegimenFiscal As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbCDFI As ComboBox

End Class
