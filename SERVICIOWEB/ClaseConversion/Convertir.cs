using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SERVICIOWEB.Clase_Conversion;

namespace SERVICIOWEB.Clase_Conversion
{
    public class Convertir
    {
        public string NumeroLetras(ulong numero)
        {
            string Respuesta;
            ConversionNumerica.NumberConversionSoapTypeClient conversion = new ConversionNumerica.NumberConversionSoapTypeClient("NumberConversionSoap");

            Respuesta = conversion.NumberToWords(numero);

            return Respuesta;
        }

        public string NumeroDollar(decimal numero)
        {
            string respuesta;
            ConversionNumerica.NumberConversionSoapTypeClient conversion2 = new ConversionNumerica.NumberConversionSoapTypeClient("NumberConversionSoap");

            respuesta = conversion2.NumberToDollars(numero);

            return respuesta;

        }
    }
}