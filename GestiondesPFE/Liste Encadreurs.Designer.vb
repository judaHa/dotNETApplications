<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Encadreurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.EncadreurBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasegestionfeDataSet = New Global.GestiondesPFE.basegestionfeDataSet
        Me.EncadreurBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EncadreurTableAdapter = New basegestionfeDataSetTableAdapters.EncadreurTableAdapter
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncadreurBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EncadreurBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FloralWhite
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DataGridView1.DataSource = Me.EncadreurBindingSource1
        Me.DataGridView1.GridColor = System.Drawing.Color.Blue
        Me.DataGridView1.Location = New System.Drawing.Point(12, 30)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(346, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'EncadreurBindingSource
        '
        Me.EncadreurBindingSource.DataMember = "Encadreur"
        '
        'BasegestionfeDataSet
        '
        Me.BasegestionfeDataSet.DataSetName = "basegestionfeDataSet"
        Me.BasegestionfeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EncadreurBindingSource1
        '
        Me.EncadreurBindingSource1.DataMember = "Encadreur"
        Me.EncadreurBindingSource1.DataSource = Me.BasegestionfeDataSet
        '
        'EncadreurTableAdapter
        '
        Me.EncadreurTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nom"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nom"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Prenom"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prenom"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'Liste_Encadreurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(370, 213)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Liste_Encadreurs"
        Me.Text = "Liste_Encadreurs"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncadreurBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EncadreurBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    'Friend WithEvents BasegestionfeDataSet As GestiondesPFE.basegestionfeDataSet
    Friend WithEvents EncadreurBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents EncadreurTableAdapter As GestiondesPFE.basegestionfeDataSetTableAdapters.EncadreurTableAdapter
    Friend WithEvents CodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BasegestionfeDataSet As Global.GestiondesPFE.basegestionfeDataSet
    Friend WithEvents EncadreurBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EncadreurTableAdapter As basegestionfeDataSetTableAdapters.EncadreurTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
