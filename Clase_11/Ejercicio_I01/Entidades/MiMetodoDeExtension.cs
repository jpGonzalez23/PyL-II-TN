namespace Entidades
{
    public static class MiMetodoDeExtension
    {
        public static string ObtenerPlacaCronicaTV (this DateTime fecha, EEstacion estacion)
        {
            DateTime hoy = DateTime.Today;
            int añoActual = hoy.Year;
            DateTime fechaEstacion = DateTime.MinValue;

            switch (estacion)
            {
                case EEstacion.Verano:
                    fechaEstacion = new DateTime(añoActual, 12, 21); // Verano comienza el 21 de diciembre
                    if (hoy >= fechaEstacion)
                    {
                        fechaEstacion = new DateTime(añoActual + 1, 12, 21);
                    }
                    break;
                case EEstacion.Primavera:
                    fechaEstacion = new DateTime(añoActual, 3, 21); // Primavera comienza el 21 de marzo
                    if (hoy >= fechaEstacion)
                    {
                        fechaEstacion = new DateTime(añoActual + 1, 3, 21);
                    }
                    break;
                case EEstacion.Invierno:
                    fechaEstacion = new DateTime(añoActual, 6, 21); // Invierno comienza el 21 de junio
                    if (hoy >= fechaEstacion)
                    {
                        fechaEstacion = new DateTime(añoActual + 1, 6, 21);
                    }
                    break;
                case EEstacion.Otonio:
                    fechaEstacion = new DateTime(añoActual, 9, 21); // Otonio comienza el 21 de septiembre
                    if (hoy >= fechaEstacion)
                    {
                        fechaEstacion = new DateTime(añoActual + 1, 9, 21);
                    }
                    break;
            }

            int diasRestantes = (int)(fechaEstacion - hoy).TotalDays;

            return $"Faltan {diasRestantes} días para el {estacion}";
        }
    }
}