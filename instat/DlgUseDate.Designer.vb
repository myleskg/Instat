﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgUseDate
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
        Me.lblDateVariable = New System.Windows.Forms.Label()
        Me.grpDateFunctions = New System.Windows.Forms.GroupBox()
        Me.grpOthers = New System.Windows.Forms.GroupBox()
        Me.grpFullName = New System.Windows.Forms.GroupBox()
        Me.grpAbbreviation = New System.Windows.Forms.GroupBox()
        Me.grpValues = New System.Windows.Forms.GroupBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.grpShifted = New System.Windows.Forms.GroupBox()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.ucrInputComboBoxMonth = New instat.ucrInputComboBox()
        Me.ucrChkShiftYear = New instat.ucrCheck()
        Me.ucrNudShiftStartDay = New instat.ucrNud()
        Me.ucrChkShiftDay = New instat.ucrCheck()
        Me.ucrChkLeapYear = New instat.ucrCheck()
        Me.ucrChkDekad = New instat.ucrCheck()
        Me.ucrChkPentad = New instat.ucrCheck()
        Me.ucrChkFullWeekday = New instat.ucrCheck()
        Me.ucrChkFullMonth = New instat.ucrCheck()
        Me.ucrChkAbbrMonth = New instat.ucrCheck()
        Me.ucrChkAbbrWeekday = New instat.ucrCheck()
        Me.ucrChkDayYear366 = New instat.ucrCheck()
        Me.ucrChkYear = New instat.ucrCheck()
        Me.ucrChkDayInYear = New instat.ucrCheck()
        Me.ucrChkMonth = New instat.ucrCheck()
        Me.ucrChkDay = New instat.ucrCheck()
        Me.ucrChkWeekday = New instat.ucrCheck()
        Me.ucrChkWeek = New instat.ucrCheck()
        Me.ucrReceiverUseDate = New instat.ucrReceiverSingle()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrSelectorUseDate = New instat.ucrSelectorByDataFrameAddRemove()
        Me.grpDateFunctions.SuspendLayout()
        Me.grpOthers.SuspendLayout()
        Me.grpFullName.SuspendLayout()
        Me.grpAbbreviation.SuspendLayout()
        Me.grpValues.SuspendLayout()
        Me.grpShifted.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDateVariable
        '
        Me.lblDateVariable.AutoSize = True
        Me.lblDateVariable.Location = New System.Drawing.Point(251, 18)
        Me.lblDateVariable.Name = "lblDateVariable"
        Me.lblDateVariable.Size = New System.Drawing.Size(71, 13)
        Me.lblDateVariable.TabIndex = 1
        Me.lblDateVariable.Text = "Date Column:"
        '
        'grpDateFunctions
        '
        Me.grpDateFunctions.Controls.Add(Me.grpShifted)
        Me.grpDateFunctions.Controls.Add(Me.grpOthers)
        Me.grpDateFunctions.Controls.Add(Me.grpFullName)
        Me.grpDateFunctions.Controls.Add(Me.grpAbbreviation)
        Me.grpDateFunctions.Controls.Add(Me.grpValues)
        Me.grpDateFunctions.Location = New System.Drawing.Point(14, 196)
        Me.grpDateFunctions.Name = "grpDateFunctions"
        Me.grpDateFunctions.Size = New System.Drawing.Size(604, 210)
        Me.grpDateFunctions.TabIndex = 3
        Me.grpDateFunctions.TabStop = False
        Me.grpDateFunctions.Text = "Date Functions"
        '
        'grpOthers
        '
        Me.grpOthers.Controls.Add(Me.ucrChkLeapYear)
        Me.grpOthers.Controls.Add(Me.ucrChkDekad)
        Me.grpOthers.Controls.Add(Me.ucrChkPentad)
        Me.grpOthers.Location = New System.Drawing.Point(6, 147)
        Me.grpOthers.Name = "grpOthers"
        Me.grpOthers.Size = New System.Drawing.Size(429, 48)
        Me.grpOthers.TabIndex = 3
        Me.grpOthers.TabStop = False
        Me.grpOthers.Text = "Other Functions"
        '
        'grpFullName
        '
        Me.grpFullName.Controls.Add(Me.ucrChkFullWeekday)
        Me.grpFullName.Controls.Add(Me.ucrChkFullMonth)
        Me.grpFullName.Location = New System.Drawing.Point(477, 19)
        Me.grpFullName.Name = "grpFullName"
        Me.grpFullName.Size = New System.Drawing.Size(106, 125)
        Me.grpFullName.TabIndex = 2
        Me.grpFullName.TabStop = False
        Me.grpFullName.Text = "Full Name"
        '
        'grpAbbreviation
        '
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrMonth)
        Me.grpAbbreviation.Controls.Add(Me.ucrChkAbbrWeekday)
        Me.grpAbbreviation.Location = New System.Drawing.Point(371, 19)
        Me.grpAbbreviation.Name = "grpAbbreviation"
        Me.grpAbbreviation.Size = New System.Drawing.Size(105, 125)
        Me.grpAbbreviation.TabIndex = 1
        Me.grpAbbreviation.TabStop = False
        Me.grpAbbreviation.Text = "Abbreviation"
        '
        'grpValues
        '
        Me.grpValues.Controls.Add(Me.ucrChkDayYear366)
        Me.grpValues.Controls.Add(Me.ucrChkYear)
        Me.grpValues.Controls.Add(Me.ucrChkDayInYear)
        Me.grpValues.Controls.Add(Me.ucrChkMonth)
        Me.grpValues.Controls.Add(Me.ucrChkDay)
        Me.grpValues.Controls.Add(Me.ucrChkWeekday)
        Me.grpValues.Controls.Add(Me.ucrChkWeek)
        Me.grpValues.Location = New System.Drawing.Point(6, 19)
        Me.grpValues.Name = "grpValues"
        Me.grpValues.Size = New System.Drawing.Size(220, 125)
        Me.grpValues.TabIndex = 0
        Me.grpValues.TabStop = False
        Me.grpValues.Text = "Values"
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Location = New System.Drawing.Point(86, 72)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(29, 13)
        Me.lblDay.TabIndex = 11
        Me.lblDay.Text = "Day:"
        '
        'grpShifted
        '
        Me.grpShifted.Controls.Add(Me.lblMonth)
        Me.grpShifted.Controls.Add(Me.ucrInputComboBoxMonth)
        Me.grpShifted.Controls.Add(Me.lblDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftYear)
        Me.grpShifted.Controls.Add(Me.ucrNudShiftStartDay)
        Me.grpShifted.Controls.Add(Me.ucrChkShiftDay)
        Me.grpShifted.Location = New System.Drawing.Point(227, 19)
        Me.grpShifted.Name = "grpShifted"
        Me.grpShifted.Size = New System.Drawing.Size(143, 125)
        Me.grpShifted.TabIndex = 4
        Me.grpShifted.TabStop = False
        Me.grpShifted.Text = "Shifted"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(1, 73)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(40, 13)
        Me.lblMonth.TabIndex = 14
        Me.lblMonth.Text = "Month:"
        '
        'ucrInputComboBoxMonth
        '
        Me.ucrInputComboBoxMonth.AddQuotesIfUnrecognised = True
        Me.ucrInputComboBoxMonth.IsReadOnly = False
        Me.ucrInputComboBoxMonth.Location = New System.Drawing.Point(3, 89)
        Me.ucrInputComboBoxMonth.Name = "ucrInputComboBoxMonth"
        Me.ucrInputComboBoxMonth.Size = New System.Drawing.Size(81, 21)
        Me.ucrInputComboBoxMonth.TabIndex = 13
        '
        'ucrChkShiftYear
        '
        Me.ucrChkShiftYear.Checked = False
        Me.ucrChkShiftYear.Location = New System.Drawing.Point(13, 46)
        Me.ucrChkShiftYear.Name = "ucrChkShiftYear"
        Me.ucrChkShiftYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkShiftYear.TabIndex = 12
        '
        'ucrNudShiftStartDay
        '
        Me.ucrNudShiftStartDay.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudShiftStartDay.Location = New System.Drawing.Point(88, 88)
        Me.ucrNudShiftStartDay.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudShiftStartDay.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudShiftStartDay.Name = "ucrNudShiftStartDay"
        Me.ucrNudShiftStartDay.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudShiftStartDay.TabIndex = 9
        Me.ucrNudShiftStartDay.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrChkShiftDay
        '
        Me.ucrChkShiftDay.Checked = False
        Me.ucrChkShiftDay.Location = New System.Drawing.Point(13, 19)
        Me.ucrChkShiftDay.Name = "ucrChkShiftDay"
        Me.ucrChkShiftDay.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkShiftDay.TabIndex = 7
        '
        'ucrChkLeapYear
        '
        Me.ucrChkLeapYear.Checked = False
        Me.ucrChkLeapYear.Location = New System.Drawing.Point(6, 19)
        Me.ucrChkLeapYear.Name = "ucrChkLeapYear"
        Me.ucrChkLeapYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkLeapYear.TabIndex = 0
        '
        'ucrChkDekad
        '
        Me.ucrChkDekad.Checked = False
        Me.ucrChkDekad.Location = New System.Drawing.Point(221, 19)
        Me.ucrChkDekad.Name = "ucrChkDekad"
        Me.ucrChkDekad.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDekad.TabIndex = 2
        '
        'ucrChkPentad
        '
        Me.ucrChkPentad.Checked = False
        Me.ucrChkPentad.Location = New System.Drawing.Point(112, 19)
        Me.ucrChkPentad.Name = "ucrChkPentad"
        Me.ucrChkPentad.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkPentad.TabIndex = 1
        '
        'ucrChkFullWeekday
        '
        Me.ucrChkFullWeekday.Checked = False
        Me.ucrChkFullWeekday.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkFullWeekday.Name = "ucrChkFullWeekday"
        Me.ucrChkFullWeekday.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullWeekday.TabIndex = 0
        '
        'ucrChkFullMonth
        '
        Me.ucrChkFullMonth.Checked = False
        Me.ucrChkFullMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkFullMonth.Name = "ucrChkFullMonth"
        Me.ucrChkFullMonth.Size = New System.Drawing.Size(90, 20)
        Me.ucrChkFullMonth.TabIndex = 1
        '
        'ucrChkAbbrMonth
        '
        Me.ucrChkAbbrMonth.Checked = False
        Me.ucrChkAbbrMonth.Location = New System.Drawing.Point(5, 43)
        Me.ucrChkAbbrMonth.Name = "ucrChkAbbrMonth"
        Me.ucrChkAbbrMonth.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrMonth.TabIndex = 1
        '
        'ucrChkAbbrWeekday
        '
        Me.ucrChkAbbrWeekday.Checked = False
        Me.ucrChkAbbrWeekday.Location = New System.Drawing.Point(5, 17)
        Me.ucrChkAbbrWeekday.Name = "ucrChkAbbrWeekday"
        Me.ucrChkAbbrWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkAbbrWeekday.TabIndex = 0
        '
        'ucrChkDayYear366
        '
        Me.ucrChkDayYear366.Checked = False
        Me.ucrChkDayYear366.Location = New System.Drawing.Point(108, 69)
        Me.ucrChkDayYear366.Name = "ucrChkDayYear366"
        Me.ucrChkDayYear366.Size = New System.Drawing.Size(109, 20)
        Me.ucrChkDayYear366.TabIndex = 6
        '
        'ucrChkYear
        '
        Me.ucrChkYear.Checked = False
        Me.ucrChkYear.Location = New System.Drawing.Point(6, 17)
        Me.ucrChkYear.Name = "ucrChkYear"
        Me.ucrChkYear.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkYear.TabIndex = 0
        '
        'ucrChkDayInYear
        '
        Me.ucrChkDayInYear.Checked = False
        Me.ucrChkDayInYear.Location = New System.Drawing.Point(108, 43)
        Me.ucrChkDayInYear.Name = "ucrChkDayInYear"
        Me.ucrChkDayInYear.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkDayInYear.TabIndex = 5
        '
        'ucrChkMonth
        '
        Me.ucrChkMonth.Checked = False
        Me.ucrChkMonth.Location = New System.Drawing.Point(6, 43)
        Me.ucrChkMonth.Name = "ucrChkMonth"
        Me.ucrChkMonth.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMonth.TabIndex = 1
        '
        'ucrChkDay
        '
        Me.ucrChkDay.Checked = False
        Me.ucrChkDay.Location = New System.Drawing.Point(6, 69)
        Me.ucrChkDay.Name = "ucrChkDay"
        Me.ucrChkDay.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkDay.TabIndex = 2
        '
        'ucrChkWeekday
        '
        Me.ucrChkWeekday.Checked = False
        Me.ucrChkWeekday.Location = New System.Drawing.Point(108, 17)
        Me.ucrChkWeekday.Name = "ucrChkWeekday"
        Me.ucrChkWeekday.Size = New System.Drawing.Size(94, 20)
        Me.ucrChkWeekday.TabIndex = 4
        '
        'ucrChkWeek
        '
        Me.ucrChkWeek.Checked = False
        Me.ucrChkWeek.Location = New System.Drawing.Point(6, 95)
        Me.ucrChkWeek.Name = "ucrChkWeek"
        Me.ucrChkWeek.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkWeek.TabIndex = 3
        '
        'ucrReceiverUseDate
        '
        Me.ucrReceiverUseDate.frmParent = Me
        Me.ucrReceiverUseDate.Location = New System.Drawing.Point(254, 39)
        Me.ucrReceiverUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverUseDate.Name = "ucrReceiverUseDate"
        Me.ucrReceiverUseDate.Selector = Nothing
        Me.ucrReceiverUseDate.Size = New System.Drawing.Size(151, 20)
        Me.ucrReceiverUseDate.strNcFilePath = ""
        Me.ucrReceiverUseDate.TabIndex = 2
        Me.ucrReceiverUseDate.ucrSelector = Nothing
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(14, 408)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(407, 52)
        Me.ucrBase.TabIndex = 4
        '
        'ucrSelectorUseDate
        '
        Me.ucrSelectorUseDate.bShowHiddenColumns = False
        Me.ucrSelectorUseDate.bUseCurrentFilter = True
        Me.ucrSelectorUseDate.Location = New System.Drawing.Point(14, 9)
        Me.ucrSelectorUseDate.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorUseDate.Name = "ucrSelectorUseDate"
        Me.ucrSelectorUseDate.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorUseDate.TabIndex = 0
        '
        'dlgUseDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 466)
        Me.Controls.Add(Me.grpDateFunctions)
        Me.Controls.Add(Me.ucrReceiverUseDate)
        Me.Controls.Add(Me.lblDateVariable)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrSelectorUseDate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgUseDate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Use Date"
        Me.grpDateFunctions.ResumeLayout(False)
        Me.grpOthers.ResumeLayout(False)
        Me.grpFullName.ResumeLayout(False)
        Me.grpAbbreviation.ResumeLayout(False)
        Me.grpValues.ResumeLayout(False)
        Me.grpShifted.ResumeLayout(False)
        Me.grpShifted.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorUseDate As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents lblDateVariable As Label
    Friend WithEvents ucrReceiverUseDate As ucrReceiverSingle
    Friend WithEvents grpDateFunctions As GroupBox
    Friend WithEvents grpOthers As GroupBox
    Friend WithEvents grpFullName As GroupBox
    Friend WithEvents grpAbbreviation As GroupBox
    Friend WithEvents grpValues As GroupBox
    Friend WithEvents ucrChkDayYear366 As ucrCheck
    Friend WithEvents ucrChkDayInYear As ucrCheck
    Friend WithEvents ucrChkWeekday As ucrCheck
    Friend WithEvents ucrChkWeek As ucrCheck
    Friend WithEvents ucrChkDay As ucrCheck
    Friend WithEvents ucrChkMonth As ucrCheck
    Friend WithEvents ucrChkYear As ucrCheck
    Friend WithEvents ucrChkFullWeekday As ucrCheck
    Friend WithEvents ucrChkFullMonth As ucrCheck
    Friend WithEvents ucrChkAbbrMonth As ucrCheck
    Friend WithEvents ucrChkAbbrWeekday As ucrCheck
    Friend WithEvents ucrChkLeapYear As ucrCheck
    Friend WithEvents ucrChkDekad As ucrCheck
    Friend WithEvents ucrChkPentad As ucrCheck
    Friend WithEvents ucrNudShiftStartDay As ucrNud
    Friend WithEvents ucrChkShiftDay As ucrCheck
    Friend WithEvents lblDay As Label
    Friend WithEvents ucrChkShiftYear As ucrCheck
    Friend WithEvents grpShifted As GroupBox
    Friend WithEvents lblMonth As Label
    Friend WithEvents ucrInputComboBoxMonth As ucrInputComboBox
End Class
