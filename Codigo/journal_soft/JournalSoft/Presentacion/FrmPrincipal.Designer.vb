<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ArchivoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgendaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContactosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MantenimientosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgramarCitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Silver
        Me.MenuStrip1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ArchivoToolStripMenuItem, Me.AgendaToolStripMenuItem, Me.ContactosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ArchivoToolStripMenuItem
        '
        Me.ArchivoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirDelSistemaToolStripMenuItem})
        Me.ArchivoToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ArchivoToolStripMenuItem.Name = "ArchivoToolStripMenuItem"
        Me.ArchivoToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ArchivoToolStripMenuItem.Text = "Archivo"
        '
        'AgendaToolStripMenuItem
        '
        Me.AgendaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramarCitaToolStripMenuItem})
        Me.AgendaToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgendaToolStripMenuItem.Name = "AgendaToolStripMenuItem"
        Me.AgendaToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.AgendaToolStripMenuItem.Text = "Agenda"
        '
        'ContactosToolStripMenuItem
        '
        Me.ContactosToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactosToolStripMenuItem.Name = "ContactosToolStripMenuItem"
        Me.ContactosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ContactosToolStripMenuItem.Text = "Contactos"
        '
        'MantenimientosToolStripMenuItem
        '
        Me.MantenimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientosToolStripMenuItem1})
        Me.MantenimientosToolStripMenuItem.Name = "MantenimientosToolStripMenuItem"
        Me.MantenimientosToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MantenimientosToolStripMenuItem.Text = "Tareas Administrativas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(197, 6)
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'MantenimientosToolStripMenuItem1
        '
        Me.MantenimientosToolStripMenuItem1.Name = "MantenimientosToolStripMenuItem1"
        Me.MantenimientosToolStripMenuItem1.Size = New System.Drawing.Size(164, 22)
        Me.MantenimientosToolStripMenuItem1.Text = "Mantenimientos"
        '
        'ProgramarCitaToolStripMenuItem
        '
        Me.ProgramarCitaToolStripMenuItem.Name = "ProgramarCitaToolStripMenuItem"
        Me.ProgramarCitaToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.ProgramarCitaToolStripMenuItem.Text = "Programar Cita"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(19, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(57, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(784, 462)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Journal Soft"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ArchivoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgendaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContactosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SalirDelSistemaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MantenimientosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgramarCitaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
