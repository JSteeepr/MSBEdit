﻿Imports System.IO

Public Class frmMSBEdit

    Public Shared bytes() As Byte
    Public Shared bigEndian As Boolean = True

    Private Sub txt_Drop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles txtMSBfile.DragDrop
        Dim file() As String = e.Data.GetData(DataFormats.FileDrop)
        sender.Text = file(0)
    End Sub
    Private Sub txt_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles txtMSBfile.DragEnter
        e.Effect = DragDropEffects.Copy
    End Sub

    Private Function StrFromBytes(ByVal loc As UInteger) As String
        Dim Str As String = ""
        Dim cont As Boolean = True

        While cont
            If bytes(loc) > 0 Then
                Str = Str + Convert.ToChar(bytes(loc))
                loc += 1
            Else
                cont = False
            End If
        End While

        Return Str
    End Function

    Private Function Int16ToTwoByte(ByVal val As Integer) As Byte()
        If bigEndian Then
            Return ReverseTwoBytes(BitConverter.GetBytes(Convert.ToInt16(val)))
        Else
            Return BitConverter.GetBytes(Convert.ToInt16(val))
        End If
    End Function
    Private Function Int32ToFourByte(ByVal val As Integer) As Byte()
        If bigEndian Then
            Return ReverseFourBytes(BitConverter.GetBytes(Convert.ToInt32(val)))
        Else
            Return BitConverter.GetBytes(Convert.ToInt32(val))
        End If
    End Function
    Private Function UInt16TotwoByte(ByVal val As UInteger) As Byte()
        If bigEndian Then
            Return ReverseTwoBytes(BitConverter.GetBytes(Convert.ToUInt16(val)))
        Else
            Return BitConverter.GetBytes(Convert.ToUInt16(val))
        End If
    End Function
    Private Function UInt32ToFourByte(ByVal val As UInteger) As Byte()
        If bigEndian Then
            Return ReverseFourBytes(BitConverter.GetBytes(Convert.ToUInt32(val)))
        Else
            Return BitConverter.GetBytes(Convert.ToUInt32(val))
        End If
    End Function
    Private Function SingleToFourByte(ByVal val As String) As Byte()
        If IsNumeric(val) Then
            If bigEndian Then
                Return ReverseFourBytes(BitConverter.GetBytes(Convert.ToSingle(val)))
            Else
                Return BitConverter.GetBytes(Convert.ToSingle(val))
            End If
        Else
            Return {0, 0, 0, 0}
        End If
    End Function
    Private Function ReverseFourBytes(ByVal byt() As Byte)
        Return {byt(3), byt(2), byt(1), byt(0)}
    End Function
    Private Function ReverseTwoBytes(ByVal byt() As Byte)
        Return {byt(1), byt(0)}
    End Function
    Private Sub InsBytes(ByVal loc As UInteger, ByVal byt As Byte())
        For i = 0 To byt.Length - 1
            bytes(loc + i) = byt(i)
        Next
    End Sub

    Private Function SingleFromFour(ByVal loc As UInteger) As Single
        Dim bArray(3) As Byte

        For i = 0 To 3
            bArray(3 - i) = bytes(loc + i)
        Next
        If Not bigEndian Then bArray = ReverseFourBytes(bArray)
        Return BitConverter.ToSingle(bArray, 0)
    End Function
    Private Function SIntFromTwo(ByVal loc As UInteger) As Int16
        Dim tmpint As Integer = 0
        Dim bArray(1) As Byte

        For i = 0 To 1
            bArray(1 - i) = bytes(loc + i)
        Next
        If Not bigEndian Then bArray = ReverseTwoBytes(bArray)
        tmpint = BitConverter.ToInt16(bArray, 0)
        Return tmpint
    End Function
    Private Function SIntFromFour(ByVal loc As UInteger) As Integer
        Dim tmpint As Integer = 0
        Dim bArray(3) As Byte

        For i = 0 To 3
            bArray(3 - i) = bytes(loc + i)
        Next
        If Not bigEndian Then bArray = ReverseFourBytes(bArray)
        tmpint = BitConverter.ToInt32(bArray, 0)
        Return tmpint
    End Function
    Private Function UIntFromTwo(ByVal loc As UInteger) As UInteger
        Dim tmpUint As UInteger = 0

        If bigEndian Then
            For i = 0 To 1
                tmpUint += Convert.ToUInt16(bytes(loc + i)) * &H100 ^ (1 - i)
            Next
        Else
            For i = 0 To 1
                tmpUint += Convert.ToUInt16(bytes(loc + i)) * &H100 ^ (i)
            Next
        End If

        Return tmpUint
    End Function
    Private Function UIntFromFour(ByVal loc As UInteger) As UInteger
        Dim tmpUint As UInteger = 0

        If bigEndian Then
            For i = 0 To 3
                tmpUint += Convert.ToUInt32(bytes(loc + i)) * &H100 ^ (3 - i)
            Next
        Else
            For i = 0 To 3
                tmpUint += Convert.ToUInt32(bytes(loc + i)) * &H100 ^ (i)
            Next
        End If

        Return tmpUint
    End Function

    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        bytes = File.ReadAllBytes(txtMSBfile.Text)

        Dim ptr As UInteger

        Dim type As UInteger

        Dim mdlindex As UInteger
        Dim objindex As UInteger
        Dim crtindex As UInteger

        Dim xpos As Single
        Dim ypos As Single
        Dim zpos As Single
        Dim facing As Single

        Dim model As String
        Dim sibpath As String

        Dim scriptid1 As Integer
        Dim scriptid2 As Integer
        Dim npcid1 As Integer
        Dim npcid2 As Integer

        Dim offset As UInteger
        Dim padding As UInteger
        Dim row(12) As String




        Dim modelPtr As UInteger
        Dim modelCnt As UInteger

        Dim eventPtr As UInteger
        Dim eventCnt As UInteger

        Dim pointPtr As UInteger
        Dim pointCnt As UInteger

        Dim partsPtr As UInteger
        Dim partsCnt As UInteger

        Dim mapstudioPtr As UInteger
        Dim mapstudioCnt As UInteger

        bigEndian = True
        If UIntFromFour(&H8) > &H10000 Then
            bigEndian = False
        End If


        modelPtr = 0
        modelCnt = UIntFromFour(&H8)

        dgvModels.Rows.Clear()
        dgvModels.Columns.Clear()

        dgvModels.Columns.Add("Type", "Type")
        dgvModels.Columns.Add("Index", "Index")
        dgvModels.Columns.Add("Model", "Model")
        dgvModels.Columns.Add("Sibpath", "Sibpath")
        dgvModels.Columns.Add("Offset", "Offset")


        eventPtr = UIntFromFour((modelCnt * &H4) + &H8)
        eventCnt = UIntFromFour(eventPtr + &H8)

        pointPtr = UIntFromFour((eventCnt * &H4) + &H8 + eventPtr)
        pointCnt = UIntFromFour(pointPtr + &H8)

        partsPtr = UIntFromFour((pointCnt * &H4) + &H8 + pointPtr)
        partsCnt = UIntFromFour(partsPtr + &H8)



        dgvObjects.Rows.Clear()
        dgvObjects.Columns.Clear()

        dgvObjects.Columns.Add("Type", "Type")
        dgvObjects.Columns.Add("Index", "Index")
        dgvObjects.Columns.Add("X pos", "X pos")
        dgvObjects.Columns.Add("Y pos", "Y pos")
        dgvObjects.Columns.Add("Z pos", "Z pos")
        dgvObjects.Columns.Add("Facing", "Facing")
        dgvObjects.Columns.Add("Model", "Model")
        dgvObjects.Columns.Add("Sibpath", "Sibpath")
        dgvObjects.Columns.Add("Offset", "Offset")


        dgvCreatures.Rows.Clear()
        dgvCreatures.Columns.Clear()
        dgvCreatures.Columns.Add("Type", "Type")
        dgvCreatures.Columns(0).Width = 40
        dgvCreatures.Columns.Add("Index", "Index")
        dgvCreatures.Columns(1).Width = 40
        dgvCreatures.Columns.Add("X pos", "X pos")
        dgvCreatures.Columns.Add("Y pos", "Y pos")
        dgvCreatures.Columns.Add("Z pos", "Z pos")
        dgvCreatures.Columns.Add("Facing", "Facing")
        dgvCreatures.Columns.Add("Model", "Model")
        dgvCreatures.Columns.Add("SibPath", "SibPath")
        dgvCreatures.Columns.Add("Script ID #1", "Script ID #1")
        'dgvCreatures.Columns.Add("Script ID #2", "Script ID #2")
        dgvCreatures.Columns.Add("NPC ID #1", "NPC ID #1")
        'dgvCreatures.Columns.Add("NPC ID #2", "NPC ID #2")

        dgvCreatures.Columns.Add("Offset", "Offset")

        For i = 0 To modelCnt - 2
            padding = 0
            ptr = UIntFromFour(modelPtr + &HC + i * &H4)

            type = UIntFromFour(ptr + &H4)
            mdlindex = UIntFromFour(ptr + &H8)
            model = StrFromBytes(ptr + &H20 + padding)
            sibpath = StrFromBytes(ptr + &H20 + model.Length + 1 + padding)

            offset = ptr

            row(0) = type
            row(1) = mdlindex
            row(2) = model
            row(3) = sibpath
            row(4) = offset

            dgvModels.Rows.Add(row)
        Next

        For i = 0 To partsCnt - 2
            padding = 0
            ptr = UIntFromFour(partsPtr + &HC + i * &H4)
            Select Case UIntFromFour(ptr + &H4)
                Case &H1, &H9
                    If bigEndian Then padding = &H4

                    If bigEndian Then padding = &H4

                    type = UIntFromFour(ptr + &H4)
                    objindex = UIntFromFour(ptr + &H8)
                    xpos = SingleFromFour(ptr + &H14)
                    ypos = SingleFromFour(ptr + &H18)
                    zpos = SingleFromFour(ptr + &H1C)

                    facing = SingleFromFour(ptr + &H24)

                    model = StrFromBytes(ptr + &H64 + padding)
                    sibpath = StrFromBytes(ptr + &H64 + model.Length + 1 + padding)

                    If sibpath.Length = 0 Then padding += 4
                    If Not bigEndian Then padding += 4

                    If Not ((sibpath.Length + model.Length + 2) Mod 4) = 0 Then
                        padding += sibpath.Length + model.Length + 2
                        padding += (4 - (padding Mod 4))
                    Else
                        padding += sibpath.Length + model.Length + 2
                    End If

                    offset = ptr

                    row(0) = type
                    row(1) = objindex
                    row(2) = xpos
                    row(3) = ypos
                    row(4) = zpos
                    row(5) = facing
                    row(6) = model
                    row(7) = sibpath
                    row(8) = offset

                    dgvObjects.Rows.Add(row)



                Case &H2, &H4

                    If bigEndian Then padding = &H4

                    type = UIntFromFour(ptr + &H4)
                    crtindex = UIntFromFour(ptr + &H8)
                    xpos = SingleFromFour(ptr + &H14)
                    ypos = SingleFromFour(ptr + &H18)
                    zpos = SingleFromFour(ptr + &H1C)

                    facing = SingleFromFour(ptr + &H24)

                    model = StrFromBytes(ptr + &H64 + padding)
                    sibpath = StrFromBytes(ptr + &H64 + model.Length + 1 + padding)

                    If sibpath.Length = 0 Then padding += 4
                    If Not bigEndian Then padding += 4

                    If Not ((sibpath.Length + model.Length + 2) Mod 4) = 0 Then
                        padding += sibpath.Length + model.Length + 2
                        padding += (4 - (padding Mod 4))
                    Else
                        padding += sibpath.Length + model.Length + 2
                    End If

                    scriptid1 = SIntFromFour(ptr + &H64 + padding)
                    npcid1 = SIntFromFour(ptr + &H64 + padding + &H24)

                    offset = ptr

                    row(0) = type
                    row(1) = crtindex
                    row(2) = xpos
                    row(3) = ypos
                    row(4) = zpos
                    row(5) = facing
                    row(6) = model
                    row(7) = sibpath
                    row(8) = scriptid1
                    row(9) = npcid1

                    row(10) = offset

                    dgvCreatures.Rows.Add(row)
            End Select
        Next

        mapstudioPtr = UIntFromFour((partsCnt * &H4) + &H8 + partsPtr)
        mapstudioCnt = UIntFromFour(mapstudioPtr + &H8)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        bytes = File.ReadAllBytes(txtMSBfile.Text)

        Dim modelPtr As UInteger
        Dim modelCnt As UInteger

        Dim eventPtr As UInteger
        Dim eventCnt As UInteger

        Dim pointPtr As UInteger
        Dim pointCnt As UInteger

        Dim partsPtr As UInteger
        Dim partsCnt As UInteger

        Dim mapstudioPtr As UInteger
        Dim mapstudioCnt As UInteger

        bigEndian = True
        If UIntFromFour(&H8) > &H10000 Then
            bigEndian = False
        End If


        modelPtr = UIntFromFour(&H4)
        modelCnt = UIntFromFour(&H8)


        eventPtr = UIntFromFour((modelCnt * &H4) + &H8)
        eventCnt = UIntFromFour(eventPtr + &H8)

        pointPtr = UIntFromFour((eventCnt * &H4) + &H8 + eventPtr)
        pointCnt = UIntFromFour(pointPtr + &H8)

        partsPtr = UIntFromFour((pointCnt * &H4) + &H8 + pointPtr)
        partsCnt = UIntFromFour(partsPtr + &H8)



        Dim ptr As UInteger

        Dim type As UInteger

        Dim mdlindex As UInteger
        Dim objindex As UInteger
        Dim crtindex As UInteger

        Dim xpos As Single
        Dim ypos As Single
        Dim zpos As Single
        Dim facing As Single

        Dim model As String
        Dim sibpath As String

        Dim scriptid1 As Integer
        Dim scriptid2 As Integer
        Dim npcid1 As Integer
        Dim npcid2 As Integer

        Dim offset As UInteger

        Dim padding As UInteger

        For i = 0 To dgvCreatures.Rows.Count - 2
            padding = 0

            If bigEndian Then padding = &H4

            type = dgvCreatures.Rows(i).Cells(0).Value
            crtindex = dgvCreatures.Rows(i).Cells(1).Value

            xpos = dgvCreatures.Rows(i).Cells(2).Value
            ypos = dgvCreatures.Rows(i).Cells(3).Value
            zpos = dgvCreatures.Rows(i).Cells(4).Value

            facing = dgvCreatures.Rows(i).Cells(5).Value

            model = dgvCreatures.Rows(i).Cells(6).Value
            sibpath = dgvCreatures.Rows(i).Cells(7).Value

            scriptid1 = dgvCreatures.Rows(i).Cells(8).Value
            npcid1 = dgvCreatures.Rows(i).Cells(9).Value
            ptr = dgvCreatures.Rows(i).Cells(10).Value

            InsBytes(ptr + &H4, UInt32ToFourByte(type))
            InsBytes(ptr + &H8, UInt32ToFourByte(crtindex))
            InsBytes(ptr + &H14, SingleToFourByte(xpos))
            InsBytes(ptr + &H18, SingleToFourByte(ypos))
            InsBytes(ptr + &H1C, SingleToFourByte(zpos))
            InsBytes(ptr + &H24, SingleToFourByte(facing))

            InsBytes(ptr + &H64 + padding, System.Text.Encoding.ASCII.GetBytes(model))
            InsBytes(ptr + &H64 + padding + model.Length + 1, System.Text.Encoding.ASCII.GetBytes(sibpath))

            If sibpath.Length = 0 Then padding += 4
            If Not bigEndian Then padding += 4

            If Not ((sibpath.Length + model.Length + 2) Mod 4) = 0 Then
                padding += sibpath.Length + model.Length + 2
                padding += (4 - (padding Mod 4))
            Else
                padding += sibpath.Length + model.Length + 2
            End If

            InsBytes(ptr + &H64 + padding, Int32ToFourByte(scriptid1))
            InsBytes(ptr + &H64 + padding + &H24, Int32ToFourByte(npcid1))
        Next

        For i = 0 To dgvModels.Rows.Count - 2
            padding = 0
            ptr = UIntFromFour(modelPtr + &HC + i * &H4)

            type = dgvModels.Rows(i).Cells(0).Value
            mdlindex = dgvModels.Rows(i).Cells(1).Value
            model = dgvModels.Rows(i).Cells(2).Value
            sibpath = dgvModels.Rows(i).Cells(3).Value

            ptr = dgvModels.Rows(i).Cells(4).Value


            InsBytes(ptr + &H4, UInt32ToFourByte(type))
            InsBytes(ptr + &H8, UInt32ToFourByte(mdlindex))

            InsBytes(ptr + &H20 + padding, System.Text.Encoding.ASCII.GetBytes(model))
            InsBytes(ptr + &H20 + padding + model.Length + 1, System.Text.Encoding.ASCII.GetBytes(sibpath))
        Next

        For i = 0 To dgvObjects.Rows.Count - 2
            padding = 0
            ptr = UIntFromFour(partsPtr + &HC + i * &H4)

            If bigEndian Then padding = &H4

            type = dgvObjects.Rows(i).Cells(0).Value
            objindex = dgvObjects.Rows(i).Cells(1).Value

            xpos = dgvObjects.Rows(i).Cells(2).Value
            ypos = dgvObjects.Rows(i).Cells(3).Value
            zpos = dgvObjects.Rows(i).Cells(4).Value

            facing = dgvObjects.Rows(i).Cells(5).Value

            model = dgvObjects.Rows(i).Cells(6).Value
            sibpath = dgvObjects.Rows(i).Cells(7).Value

            ptr = dgvObjects.Rows(i).Cells(8).Value

            InsBytes(ptr + &H4, UInt32ToFourByte(type))
            InsBytes(ptr + &H8, UInt32ToFourByte(objindex))
            InsBytes(ptr + &H14, SingleToFourByte(xpos))
            InsBytes(ptr + &H18, SingleToFourByte(ypos))
            InsBytes(ptr + &H1C, SingleToFourByte(zpos))
            InsBytes(ptr + &H24, SingleToFourByte(facing))

            InsBytes(ptr + &H64 + padding, System.Text.Encoding.ASCII.GetBytes(model))
            InsBytes(ptr + &H64 + padding + model.Length + 1, System.Text.Encoding.ASCII.GetBytes(sibpath))
        Next



        File.WriteAllBytes(txtMSBfile.Text, bytes)

        MsgBox("Save Complete.")
    End Sub
End Class
