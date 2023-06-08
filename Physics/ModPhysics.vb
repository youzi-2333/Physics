Public Module ModPhysics
    Public Enum Facing
        North = 0
        South = 180
        West = -90
        East = 90
        Above = 90
        Below = -90
    End Enum
    Public Class Force
        ''' <summary>
        ''' 力的大小，单位为牛(N)。
        ''' </summary>
        Public Property Amount As Double
        ''' <summary>
        ''' 力的水平方向。正北、正南、正西、正东分别为 0、180、-90、90。
        ''' </summary>
        Public Property Horizontal As Double
        ''' <summary>
        ''' 力的仰角方向。正上方为 90，正下方为 -90，水平为 0。
        ''' </summary>
        Public Property Elevation As Double
        ''' <summary>
        ''' 力作用点的 X 坐标。
        ''' </summary>
        Public Property X As Double
        ''' <summary>
        ''' 力作用点的 Y 坐标。
        ''' </summary>
        Public Property Y As Double
        ''' <summary>
        ''' 力作用点的 Z 坐标。
        ''' </summary>
        Public Property Z As Double
        ''' <summary>
        ''' 在坐标原点创建 0N 大小的、水平的、向正北方向的力。
        ''' </summary>
        Public Sub New()
            Amount = 0
            Horizontal = 0
        End Sub
    End Class
End Module
