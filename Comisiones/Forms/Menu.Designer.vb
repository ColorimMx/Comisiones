<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ComisionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenteFamiliaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenteClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgenteTipoCobroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComisionesVmgToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComisionesToolStripMenuItem, Me.ComisionesVmgToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(434, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ComisionesToolStripMenuItem
        '
        Me.ComisionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgenteFamiliaToolStripMenuItem, Me.AgenteClienteToolStripMenuItem, Me.AgenteTipoCobroToolStripMenuItem})
        Me.ComisionesToolStripMenuItem.Name = "ComisionesToolStripMenuItem"
        Me.ComisionesToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ComisionesToolStripMenuItem.Text = "Comisiones MBA3"
        '
        'AgenteFamiliaToolStripMenuItem
        '
        Me.AgenteFamiliaToolStripMenuItem.Name = "AgenteFamiliaToolStripMenuItem"
        Me.AgenteFamiliaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AgenteFamiliaToolStripMenuItem.Text = "Agente-Familia"
        '
        'AgenteClienteToolStripMenuItem
        '
        Me.AgenteClienteToolStripMenuItem.Name = "AgenteClienteToolStripMenuItem"
        Me.AgenteClienteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AgenteClienteToolStripMenuItem.Text = "Agente-Cliente"
        '
        'AgenteTipoCobroToolStripMenuItem
        '
        Me.AgenteTipoCobroToolStripMenuItem.Name = "AgenteTipoCobroToolStripMenuItem"
        Me.AgenteTipoCobroToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.AgenteTipoCobroToolStripMenuItem.Text = "Agente-Tipo Cobro"
        '
        'ComisionesVmgToolStripMenuItem
        '
        Me.ComisionesVmgToolStripMenuItem.Name = "ComisionesVmgToolStripMenuItem"
        Me.ComisionesVmgToolStripMenuItem.Size = New System.Drawing.Size(116, 20)
        Me.ComisionesVmgToolStripMenuItem.Text = "Comisiones VMFG"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 21)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Menu"
        Me.Text = "Colorantes Importados S.A. de C.V."
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ComisionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenteFamiliaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenteClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgenteTipoCobroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComisionesVmgToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
