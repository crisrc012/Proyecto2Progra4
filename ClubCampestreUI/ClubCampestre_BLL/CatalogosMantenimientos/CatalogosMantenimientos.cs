namespace ClubCampestre_BLL.CatalogosMantenimientos
{
    public enum BD : byte { Actualizar, Insertar, Eliminar, Listar, Filtrar, FiltrarVista };
    public enum Rol : byte { Administrador = 1, Operario, Cliente };
}
