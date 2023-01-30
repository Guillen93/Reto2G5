namespace Reto2G5.Model
{
    public class PaginationMetaData
    {
        public int CurrentPage { get; set; }
        //pagina que el usuario está viendo
        public int TotalPages { get; set; }
        public int TotalCount { get; set; }
        //cuantos pokemos hay en total
        public bool HasPrevious => CurrentPage > 1;
        //solo es un GET,
        //es false si estamos en la primera pagina, no hay pag previa
        public bool HasNext => CurrentPage < TotalPages;
        //solo es un GET,
        //es false si estamos en la última página.
    }
}
