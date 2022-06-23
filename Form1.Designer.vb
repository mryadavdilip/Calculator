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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btn_del = New System.Windows.Forms.Button()
        Me.btn_c = New System.Windows.Forms.Button()
        Me.TextField = New System.Windows.Forms.TextBox()
        Me.input_equation = New System.Windows.Forms.Label()
        Me.btn_ce = New System.Windows.Forms.Button()
        Me.btn_equal = New System.Windows.Forms.Button()
        Me.btn_decimal_point = New System.Windows.Forms.Button()
        Me.btn_num_zero = New System.Windows.Forms.Button()
        Me.btn_negative = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_num_seven = New System.Windows.Forms.Button()
        Me.btn_num_eight = New System.Windows.Forms.Button()
        Me.btn_num_nine = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_subtract = New System.Windows.Forms.Button()
        Me.btn_num_six = New System.Windows.Forms.Button()
        Me.btn_num_five = New System.Windows.Forms.Button()
        Me.btn_num_four = New System.Windows.Forms.Button()
        Me.btn_num_one = New System.Windows.Forms.Button()
        Me.btn_inverse = New System.Windows.Forms.Button()
        Me.btn_num_two = New System.Windows.Forms.Button()
        Me.btn_sqr = New System.Windows.Forms.Button()
        Me.btn_num_three = New System.Windows.Forms.Button()
        Me.btn_multiply = New System.Windows.Forms.Button()
        Me.btn_divide = New System.Windows.Forms.Button()
        Me.btn_sqrt = New System.Windows.Forms.Button()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.btn_check = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_del
        '
        Me.btn_del.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_del.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_del.Location = New System.Drawing.Point(300, 3)
        Me.btn_del.Name = "btn_del"
        Me.btn_del.Size = New System.Drawing.Size(95, 54)
        Me.btn_del.TabIndex = 81
        Me.btn_del.Text = "⌫"
        Me.btn_del.UseVisualStyleBackColor = True
        '
        'btn_c
        '
        Me.btn_c.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_c.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_c.Location = New System.Drawing.Point(102, 3)
        Me.btn_c.Name = "btn_c"
        Me.btn_c.Size = New System.Drawing.Size(93, 54)
        Me.btn_c.TabIndex = 80
        Me.btn_c.Text = "C"
        Me.btn_c.UseVisualStyleBackColor = True
        '
        'TextField
        '
        Me.TextField.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextField.BackColor = System.Drawing.SystemColors.Control
        Me.TextField.Enabled = False
        Me.TextField.Font = New System.Drawing.Font("Segoe UI Semibold", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextField.Location = New System.Drawing.Point(3, 47)
        Me.TextField.MaxLength = 14
        Me.TextField.Name = "TextField"
        Me.TextField.ReadOnly = True
        Me.TextField.Size = New System.Drawing.Size(392, 77)
        Me.TextField.TabIndex = 79
        Me.TextField.Text = "0"
        Me.TextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'input_equation
        '
        Me.input_equation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.input_equation.AutoSize = True
        Me.input_equation.CausesValidation = False
        Me.input_equation.Location = New System.Drawing.Point(3, 6)
        Me.input_equation.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.input_equation.Name = "input_equation"
        Me.input_equation.Size = New System.Drawing.Size(0, 32)
        Me.input_equation.TabIndex = 78
        Me.input_equation.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_ce
        '
        Me.btn_ce.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ce.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_ce.Location = New System.Drawing.Point(3, 3)
        Me.btn_ce.Name = "btn_ce"
        Me.btn_ce.Size = New System.Drawing.Size(93, 54)
        Me.btn_ce.TabIndex = 77
        Me.btn_ce.Text = "CE"
        Me.btn_ce.UseVisualStyleBackColor = True
        '
        'btn_equal
        '
        Me.btn_equal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_equal.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_equal.Location = New System.Drawing.Point(300, 307)
        Me.btn_equal.Name = "btn_equal"
        Me.btn_equal.Size = New System.Drawing.Size(95, 56)
        Me.btn_equal.TabIndex = 60
        Me.btn_equal.Text = "="
        Me.btn_equal.UseVisualStyleBackColor = True
        '
        'btn_decimal_point
        '
        Me.btn_decimal_point.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_decimal_point.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_decimal_point.Location = New System.Drawing.Point(201, 307)
        Me.btn_decimal_point.Name = "btn_decimal_point"
        Me.btn_decimal_point.Size = New System.Drawing.Size(93, 56)
        Me.btn_decimal_point.TabIndex = 59
        Me.btn_decimal_point.Text = "."
        Me.btn_decimal_point.UseVisualStyleBackColor = True
        '
        'btn_num_zero
        '
        Me.btn_num_zero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_zero.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_zero.Location = New System.Drawing.Point(102, 307)
        Me.btn_num_zero.Name = "btn_num_zero"
        Me.btn_num_zero.Size = New System.Drawing.Size(93, 56)
        Me.btn_num_zero.TabIndex = 58
        Me.btn_num_zero.Text = "0"
        Me.btn_num_zero.UseVisualStyleBackColor = True
        '
        'btn_negative
        '
        Me.btn_negative.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_negative.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_negative.Location = New System.Drawing.Point(3, 307)
        Me.btn_negative.Name = "btn_negative"
        Me.btn_negative.Size = New System.Drawing.Size(93, 56)
        Me.btn_negative.TabIndex = 57
        Me.btn_negative.Text = "±"
        Me.btn_negative.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btn_check, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_negative, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_c, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_zero, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_ce, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_decimal_point, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_equal, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_seven, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_eight, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_nine, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_add, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_subtract, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_six, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_five, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_four, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_one, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_inverse, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sqr, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_three, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_multiply, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_divide, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_sqrt, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_del, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btn_num_two, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 212)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 6
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66319!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66736!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(398, 366)
        Me.TableLayoutPanel1.TabIndex = 82
        '
        'btn_num_seven
        '
        Me.btn_num_seven.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_seven.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_seven.Location = New System.Drawing.Point(3, 246)
        Me.btn_num_seven.Name = "btn_num_seven"
        Me.btn_num_seven.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_seven.TabIndex = 61
        Me.btn_num_seven.Text = "7"
        Me.btn_num_seven.UseVisualStyleBackColor = True
        '
        'btn_num_eight
        '
        Me.btn_num_eight.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_eight.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_eight.Location = New System.Drawing.Point(102, 246)
        Me.btn_num_eight.Name = "btn_num_eight"
        Me.btn_num_eight.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_eight.TabIndex = 62
        Me.btn_num_eight.Text = "8"
        Me.btn_num_eight.UseVisualStyleBackColor = True
        '
        'btn_num_nine
        '
        Me.btn_num_nine.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_nine.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_nine.Location = New System.Drawing.Point(201, 246)
        Me.btn_num_nine.Name = "btn_num_nine"
        Me.btn_num_nine.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_nine.TabIndex = 63
        Me.btn_num_nine.Text = "9"
        Me.btn_num_nine.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_add.Location = New System.Drawing.Point(300, 246)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(95, 55)
        Me.btn_add.TabIndex = 64
        Me.btn_add.Text = "+"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_subtract
        '
        Me.btn_subtract.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_subtract.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_subtract.Location = New System.Drawing.Point(300, 185)
        Me.btn_subtract.Name = "btn_subtract"
        Me.btn_subtract.Size = New System.Drawing.Size(95, 55)
        Me.btn_subtract.TabIndex = 68
        Me.btn_subtract.Text = "-"
        Me.btn_subtract.UseVisualStyleBackColor = True
        '
        'btn_num_six
        '
        Me.btn_num_six.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_six.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_six.Location = New System.Drawing.Point(201, 185)
        Me.btn_num_six.Name = "btn_num_six"
        Me.btn_num_six.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_six.TabIndex = 67
        Me.btn_num_six.Text = "6"
        Me.btn_num_six.UseVisualStyleBackColor = True
        '
        'btn_num_five
        '
        Me.btn_num_five.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_five.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_five.Location = New System.Drawing.Point(102, 185)
        Me.btn_num_five.Name = "btn_num_five"
        Me.btn_num_five.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_five.TabIndex = 66
        Me.btn_num_five.Text = "5"
        Me.btn_num_five.UseVisualStyleBackColor = True
        '
        'btn_num_four
        '
        Me.btn_num_four.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_four.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_four.Location = New System.Drawing.Point(3, 185)
        Me.btn_num_four.Name = "btn_num_four"
        Me.btn_num_four.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_four.TabIndex = 65
        Me.btn_num_four.Text = "4"
        Me.btn_num_four.UseVisualStyleBackColor = True
        '
        'btn_num_one
        '
        Me.btn_num_one.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_one.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_one.Location = New System.Drawing.Point(3, 124)
        Me.btn_num_one.Name = "btn_num_one"
        Me.btn_num_one.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_one.TabIndex = 69
        Me.btn_num_one.Text = "1"
        Me.btn_num_one.UseVisualStyleBackColor = True
        '
        'btn_inverse
        '
        Me.btn_inverse.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_inverse.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_inverse.Location = New System.Drawing.Point(3, 63)
        Me.btn_inverse.Name = "btn_inverse"
        Me.btn_inverse.Size = New System.Drawing.Size(93, 55)
        Me.btn_inverse.TabIndex = 73
        Me.btn_inverse.Text = "⅟x"
        Me.btn_inverse.UseVisualStyleBackColor = True
        '
        'btn_num_two
        '
        Me.btn_num_two.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_two.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_two.Location = New System.Drawing.Point(102, 124)
        Me.btn_num_two.Name = "btn_num_two"
        Me.btn_num_two.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_two.TabIndex = 70
        Me.btn_num_two.Text = "2"
        Me.btn_num_two.UseVisualStyleBackColor = True
        '
        'btn_sqr
        '
        Me.btn_sqr.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sqr.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_sqr.Location = New System.Drawing.Point(102, 63)
        Me.btn_sqr.Name = "btn_sqr"
        Me.btn_sqr.Size = New System.Drawing.Size(93, 55)
        Me.btn_sqr.TabIndex = 74
        Me.btn_sqr.Text = "x²"
        Me.btn_sqr.UseVisualStyleBackColor = True
        '
        'btn_num_three
        '
        Me.btn_num_three.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_num_three.Font = New System.Drawing.Font("Segoe UI Semibold", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_num_three.Location = New System.Drawing.Point(201, 124)
        Me.btn_num_three.Name = "btn_num_three"
        Me.btn_num_three.Size = New System.Drawing.Size(93, 55)
        Me.btn_num_three.TabIndex = 71
        Me.btn_num_three.Text = "3"
        Me.btn_num_three.UseVisualStyleBackColor = True
        '
        'btn_multiply
        '
        Me.btn_multiply.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_multiply.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_multiply.Location = New System.Drawing.Point(300, 124)
        Me.btn_multiply.Name = "btn_multiply"
        Me.btn_multiply.Size = New System.Drawing.Size(95, 55)
        Me.btn_multiply.TabIndex = 72
        Me.btn_multiply.Text = "×"
        Me.btn_multiply.UseVisualStyleBackColor = True
        '
        'btn_divide
        '
        Me.btn_divide.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_divide.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_divide.Location = New System.Drawing.Point(300, 63)
        Me.btn_divide.Name = "btn_divide"
        Me.btn_divide.Size = New System.Drawing.Size(95, 55)
        Me.btn_divide.TabIndex = 76
        Me.btn_divide.Text = "÷"
        Me.btn_divide.UseVisualStyleBackColor = True
        '
        'btn_sqrt
        '
        Me.btn_sqrt.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_sqrt.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_sqrt.Location = New System.Drawing.Point(201, 63)
        Me.btn_sqrt.Name = "btn_sqrt"
        Me.btn_sqrt.Size = New System.Drawing.Size(93, 55)
        Me.btn_sqrt.TabIndex = 75
        Me.btn_sqrt.Text = "√x"
        Me.btn_sqrt.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.TextField, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.input_equation, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(12, 78)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 2
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.08772!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.91228!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(398, 127)
        Me.TableLayoutPanel3.TabIndex = 84
        '
        'btn_check
        '
        Me.btn_check.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_check.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btn_check.Location = New System.Drawing.Point(201, 3)
        Me.btn_check.Name = "btn_check"
        Me.btn_check.Size = New System.Drawing.Size(93, 54)
        Me.btn_check.TabIndex = 85
        Me.btn_check.Text = "check"
        Me.btn_check.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(422, 594)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(444, 650)
        Me.Name = "Form1"
        Me.Opacity = 0.95R
        Me.Text = "Calculator"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_del As Button
    Friend WithEvents btn_c As Button
    Friend WithEvents TextField As TextBox
    Friend WithEvents input_equation As Label
    Friend WithEvents btn_ce As Button
    Friend WithEvents btn_equal As Button
    Friend WithEvents btn_decimal_point As Button
    Friend WithEvents btn_num_zero As Button
    Friend WithEvents btn_negative As Button
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents btn_num_seven As Button
    Friend WithEvents btn_num_eight As Button
    Friend WithEvents btn_num_nine As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents btn_subtract As Button
    Friend WithEvents btn_num_six As Button
    Friend WithEvents btn_num_five As Button
    Friend WithEvents btn_num_four As Button
    Friend WithEvents btn_num_one As Button
    Friend WithEvents btn_inverse As Button
    Friend WithEvents btn_num_two As Button
    Friend WithEvents btn_sqr As Button
    Friend WithEvents btn_num_three As Button
    Friend WithEvents btn_multiply As Button
    Friend WithEvents btn_divide As Button
    Friend WithEvents btn_sqrt As Button
    Friend WithEvents btn_check As Button
End Class
