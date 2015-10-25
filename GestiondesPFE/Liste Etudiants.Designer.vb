<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Liste_Etudiants
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
        Me.BasegestionfeDataSet = New Global.GestiondesPFE.basegestionfeDataSet
        Me.EtudiantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EtudiantTableAdapter = New basegestionfeDataSetTableAdapters.EtudiantTableAdapter
        Me.NCEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CINDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.PrenomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateDeNaissanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FiliereDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EtudiantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Snow
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NCEDataGridViewTextBoxColumn, Me.CINDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.PrenomDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.TelDataGridViewTextBoxColumn, Me.DateDeNaissanceDataGridViewTextBoxColumn, Me.FiliereDataGridViewTextBoxColumn, Me.StageDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EtudiantBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 40)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(948, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'BasegestionfeDataSet
        '
        Me.BasegestionfeDataSet.DataSetName = "basegestionfeDataSet"
        Me.BasegestionfeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EtudiantBindingSource
        '
        Me.EtudiantBindingSource.DataMember = "Etudiant"
        Me.EtudiantBindingSource.DataSource = Me.BasegestionfeDataSet
        '
        'EtudiantTableAdapter
        '
        Me.EtudiantTableAdapter.ClearBeforeFill = True
        '
        'NCEDataGridViewTextBoxColumn
        '
        Me.NCEDataGridViewTextBoxColumn.DataPropertyName = "NCE"
        Me.NCEDataGridViewTextBoxColumn.HeaderText = "NCE"
        Me.NCEDataGridViewTextBoxColumn.Name = "NCEDataGridViewTextBoxColumn"
        '
        'CINDataGridViewTextBoxColumn
        '
        Me.CINDataGridViewTextBoxColumn.DataPropertyName = "CIN"
        Me.CINDataGridViewTextBoxColumn.HeaderText = "CIN"
        Me.CINDataGridViewTextBoxColumn.Name = "CINDataGridViewTextBoxColumn"
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        '
        'PrenomDataGridViewTextBoxColumn
        '
        Me.PrenomDataGridViewTextBoxColumn.DataPropertyName = "prenom"
        Me.PrenomDataGridViewTextBoxColumn.HeaderText = "prenom"
        Me.PrenomDataGridViewTextBoxColumn.Name = "PrenomDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'TelDataGridViewTextBoxColumn
        '
        Me.TelDataGridViewTextBoxColumn.DataPropertyName = "tel"
        Me.TelDataGridViewTextBoxColumn.HeaderText = "tel"
        Me.TelDataGridViewTextBoxColumn.Name = "TelDataGridViewTextBoxColumn"
        '
        'DateDeNaissanceDataGridViewTextBoxColumn
        '
        Me.DateDeNaissanceDataGridViewTextBoxColumn.DataPropertyName = "date de naissance"
        Me.DateDeNaissanceDataGridViewTextBoxColumn.HeaderText = "date de naissance"
        Me.DateDeNaissanceDataGridViewTextBoxColumn.Name = "DateDeNaissanceDataGridViewTextBoxColumn"
        '
        'FiliereDataGridViewTextBoxColumn
        '
        Me.FiliereDataGridViewTextBoxColumn.DataPropertyName = "filiere"
        Me.FiliereDataGridViewTextBoxColumn.HeaderText = "filiere"
        Me.FiliereDataGridViewTextBoxColumn.Name = "FiliereDataGridViewTextBoxColumn"
        '
        'StageDataGridViewTextBoxColumn
        '
        Me.StageDataGridViewTextBoxColumn.DataPropertyName = "Stage"
        Me.StageDataGridViewTextBoxColumn.HeaderText = "Stage"
        Me.StageDataGridViewTextBoxColumn.Name = "StageDataGridViewTextBoxColumn"
        '
        'Liste_Etudiants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cornsilk
        Me.ClientSize = New System.Drawing.Size(991, 229)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Liste_Etudiants"
        Me.Text = "Liste_Etudiants"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasegestionfeDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EtudiantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BasegestionfeDataSet As Global.GestiondesPFE.basegestionfeDataSet
    Friend WithEvents EtudiantBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EtudiantTableAdapter As basegestionfeDataSetTableAdapters.EtudiantTableAdapter
    Friend WithEvents NCEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CINDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrenomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateDeNaissanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FiliereDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
