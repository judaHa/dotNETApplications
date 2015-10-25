Imports System
Imports System.Data.OleDb
Imports System.Data
Imports GestiondesPFE

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Projets
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
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ProjetBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasegestionfeDataSet = New Global.GestiondesPFE.basegestionfeDataSet
        Me.ProjetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjetBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProjetTableAdapter = New basegestionfeDataSetTableAdapters.ProjetTableAdapter
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjetBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProjetBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.DataGridView1.DataSource = Me.ProjetBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(12, 35)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(550, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Nproje"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Nproje"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Titre"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Titre"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DateDepot"
        Me.DataGridViewTextBoxColumn9.HeaderText = "DateDepot"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Date soutenance"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Date soutenance"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'ProjetBindingSource2
        '
        Me.ProjetBindingSource2.DataMember = "Projet"
        Me.ProjetBindingSource2.DataSource = Me.BasegestionfeDataSet
        '
        'BasegestionfeDataSet
        '
        Me.BasegestionfeDataSet.DataSetName = "basegestionfeDataSet"
        Me.BasegestionfeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProjetBindingSource
        '
        Me.ProjetBindingSource.DataMember = "Projet"
        '
        'ProjetBindingSource1
        '
        Me.ProjetBindingSource1.DataMember = "Projet"
        Me.ProjetBindingSource1.DataSource = Me.BasegestionfeDataSet
        '
        'ProjetTableAdapter
        '
        Me.ProjetTableAdapter.ClearBeforeFill = True
        '
        'Liste_Projets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(584, 212)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Liste_Projets"
        Me.Text = "Liste_Projets"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjetBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProjetBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BasegestionfeDataSet As Global.GestiondesPFE.basegestionfeDataSet
    Friend WithEvents ProjetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProjetTableAdapter As basegestionfeDataSetTableAdapters.ProjetTableAdapter
    Friend WithEvents NprojeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TitreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDepotDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSoutenanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    'Friend WithEvents BasegestionfeDataSet As Global.GestiondesPFE.basegestionfeDataSet
    Friend WithEvents ProjetBindingSource1 As System.Windows.Forms.BindingSource
    ' Friend WithEvents ProjetTableAdapter As basegestionfeDataSetTableAdapters.ProjetTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProjetBindingSource2 As System.Windows.Forms.BindingSource
End Class
