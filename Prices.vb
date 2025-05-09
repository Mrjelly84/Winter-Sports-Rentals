Public Class Prices
    Private Shared Property InsuranceRate As Double = 0.1

    Enum DurationType
        oneDay
        twoDay
        threeDay
        oneWeek
        twoWeek

    End Enum

    Enum EquipmentType
        Skis_Basic
        Skis_Advanced
        Snow_Basic
        Snow_Advanced
        Ski_Boots
        Snow_Boots
        Helmet_Std
        Helmet_Dekuxe

    End Enum

    Private prices(,) As Double =
        {{35, 45, 80, 150, 280},
        {45, 55, 90, 170, 320},
        {32, 42, 78, 148, 275},
        {45, 55, 100, 175, 335},
        {10, 15, 25, 50, 90},
        {10, 15, 25, 50, 90},
        {10, 15, 20, 45, 80},
        {10, 12, 15, 50, 90},
        {15, 20, 25, 70, 110}}

    Public Function GetRentalPrice(equip As EquipmentType, duration As DurationType) As Double
        Return prices(equip, duration)
    End Function

    Public Shared ReadOnly Property InsuranceCost(rentalAmount As Double)
        Get
            Return rentalAmount * InsuranceRate

        End Get
    End Property


End Class
