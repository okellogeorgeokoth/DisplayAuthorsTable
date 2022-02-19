<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DisplayAuthorsTableApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        Me.showAllButton = New System.Windows.Forms.Button()
        Me.AuthorDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter LastName of Author to search"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(55, 73)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(192, 23)
        Me.searchTextBox.TabIndex = 1
        '
        'searchButton
        '
        Me.searchButton.Location = New System.Drawing.Point(389, 72)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(102, 24)
        Me.searchButton.TabIndex = 2
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = True
        '
        'showAllButton
        '
        Me.showAllButton.Location = New System.Drawing.Point(389, 118)
        Me.showAllButton.Name = "showAllButton"
        Me.showAllButton.Size = New System.Drawing.Size(102, 28)
        Me.showAllButton.TabIndex = 3
        Me.showAllButton.Text = "Show all"
        Me.showAllButton.UseVisualStyleBackColor = True
        '
        'AuthorDataGridView
        '
        Me.AuthorDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AuthorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AuthorDataGridView.Location = New System.Drawing.Point(32, 173)
        Me.AuthorDataGridView.Name = "AuthorDataGridView"
        Me.AuthorDataGridView.Size = New System.Drawing.Size(468, 252)
        Me.AuthorDataGridView.TabIndex = 4
        '
        'DisplayAuthorsTableApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 447)
        Me.Controls.Add(Me.AuthorDataGridView)
        Me.Controls.Add(Me.showAllButton)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "DisplayAuthorsTableApp"
        Me.Text = "Display Authors Table"
        CType(Me.AuthorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
    Friend WithEvents showAllButton As Button
    Friend WithEvents AuthorDataGridView As DataGridView
End Class
