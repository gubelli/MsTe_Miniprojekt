﻿using AutoReservation.Common.DataTransferObjects.Core;

namespace AutoReservation.Common.DataTransferObjects
{
    public class AutoDto //: DtoBase<AutoDto>
    {

        //public override string Validate()
        //{
        //    StringBuilder error = new StringBuilder();
        //    if (string.IsNullOrEmpty(marke))
        //    {
        //        error.AppendLine("- Marke ist nicht gesetzt.");
        //    }
        //    if (tagestarif <= 0)
        //    {
        //        error.AppendLine("- Tagestarif muss grösser als 0 sein.");
        //    }
        //    if (AutoKlasse == AutoKlasse.Luxusklasse && basistarif <= 0)
        //    {
        //        error.AppendLine("- Basistarif eines Luxusautos muss grösser als 0 sein.");
        //    }

        //    if (error.Length == 0) { return null; }

        //    return error.ToString();
        //}

        //public override string ToString()
        //    => $"{Id}; {Marke}; {Tagestarif}; {Basistarif}; {AutoKlasse}";

    }
}
