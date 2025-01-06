'Developer Name: Brennan Kunicki
'Program Name: Binary Clock
'Date: 12/12/24
'Purpose of Program: Shows a binary representation of the current time.
Public Class frmBinaryClock
    Const _cintTimerSpeed = 500

    Private Sub frmBinaryClock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Begins timer control
        BinaryTimer.Interval = _cintTimerSpeed
        BinaryTimer.Start()
    End Sub

    Private Sub BinaryTimer_Tick(sender As Object, e As EventArgs) Handles BinaryTimer.Tick
        'Updates all timer images through their respective sub procedures
        Dim intHour1 As Integer = Now.Hour.ToString("D2").Substring(0, 1)
        Dim intHour2 As Integer = Now.Hour.ToString("D2").Substring(1, 1)

        Dim intMinute1 As Integer = Now.Minute.ToString("D2").Substring(0, 1)
        Dim intMinute2 As Integer = Now.Minute.ToString("D2").Substring(1, 1)

        Dim intSecond1 As Integer = Now.Second.ToString("D2").Substring(0, 1)
        Dim intSecond2 As Integer = Now.Second.ToString("D2").Substring(1, 1)

        TimerHourUpdate(intHour1, intHour2)
        TimerMinuteUpdate(intMinute1, intMinute2)
        TimerSecondUpdate(intSecond1, intSecond2)
    End Sub

    Private Sub TimerHourUpdate(ByRef hour1 As Integer, ByRef hour2 As Integer)
        'Updates the hour PictureBoxes
        Dim arrHours1 As PictureBox() = {picHour1_1, picHour1_2}
        Dim arrHours2 As PictureBox() = {picHour2_1, picHour2_2, picHour2_4, picHour2_8}
        Array.Reverse(arrHours1)
        Array.Reverse(arrHours2)

        'Updates the PictureBoxes representing the ones place
        For Each time1 As PictureBox In arrHours1
            Dim time As Integer = Convert.ToInt16(time1.Name.Substring(time1.Name.Length - 1, 1))
            If time <= hour1 Then
                time1.Image = My.Resources.LightOn
                hour1 -= time
            Else
                time1.Image = My.Resources.LightOff
            End If
        Next

        'Updates the PictureBoxes representing the tens place
        For Each time2 As PictureBox In arrHours2
            Dim time As Integer = Convert.ToInt16(time2.Name.Substring(time2.Name.Length - 1, 1))
            If time <= hour2 Then
                time2.Image = My.Resources.LightOn
                hour2 -= time
            Else
                time2.Image = My.Resources.LightOff
            End If
        Next
    End Sub

    Private Sub TimerMinuteUpdate(ByRef minute1 As Integer, ByRef minute2 As Integer)
        'Updates the minute PictureBoxes
        Dim arrMinutes1 As PictureBox() = {picMinute1_1, picMinute1_2, picMinute1_4}
        Dim arrMinutes2 As PictureBox() = {picMinute2_1, picMinute2_2, picMinute2_4, picMinute2_8}
        Array.Reverse(arrMinutes1)
        Array.Reverse(arrMinutes2)

        'Updates the PictureBoxes representing the ones place
        For Each time1 As PictureBox In arrMinutes1
            Dim time As Integer = Convert.ToInt16(time1.Name.Substring(time1.Name.Length - 1, 1))
            If time <= minute1 Then
                time1.Image = My.Resources.LightOn
                minute1 -= time
            Else
                time1.Image = My.Resources.LightOff
            End If
        Next

        'Updates the PictureBoxes representing the tens place
        For Each time2 As PictureBox In arrMinutes2
            Dim time As Integer = Convert.ToInt16(time2.Name.Substring(time2.Name.Length - 1, 1))
            If time <= minute2 Then
                time2.Image = My.Resources.LightOn
                minute2 -= time
            Else
                time2.Image = My.Resources.LightOff
            End If
        Next
    End Sub

    Private Sub TimerSecondUpdate(ByRef second1 As Integer, ByRef second2 As Integer)
        'Updates the second PictureBoxes
        Dim arrSeconds1 As PictureBox() = {picSecond1_1, picSecond1_2}
        Dim arrSeconds2 As PictureBox() = {picSecond2_1, picSecond2_2, picSecond2_4, picSecond2_8}
        Array.Reverse(arrSeconds1)
        Array.Reverse(arrSeconds2)

        'Updates the PictureBoxes representing the ones place
        For Each time1 As PictureBox In arrSeconds1
            Dim time As Integer = Convert.ToInt16(time1.Name.Substring(time1.Name.Length - 1, 1))
            If time <= second1 Then
                time1.Image = My.Resources.LightOn
                second1 -= time
            Else
                time1.Image = My.Resources.LightOff
            End If
        Next

        'Updates the PictureBoxes representing the tens place
        For Each time2 As PictureBox In arrSeconds2
            Dim time As Integer = Convert.ToInt16(time2.Name.Substring(time2.Name.Length - 1, 1))
            If time <= second2 Then
                time2.Image = My.Resources.LightOn
                second2 -= time
            Else
                time2.Image = My.Resources.LightOff
            End If
        Next
    End Sub
End Class
