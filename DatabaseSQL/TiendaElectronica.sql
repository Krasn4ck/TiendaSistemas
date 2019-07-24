SET FOREIGN_KEY_CHECKS=0

DROP TABLE IF EXISTS `Clientes` CASCADE
;

DROP TABLE IF EXISTS `PepsProductos` CASCADE
;

DROP TABLE IF EXISTS `Productos` CASCADE
;

DROP TABLE IF EXISTS `Proveedores` CASCADE
;

DROP TABLE IF EXISTS `ReportesGeneral` CASCADE
;

DROP TABLE IF EXISTS `SurtirInventario` CASCADE
;

DROP TABLE IF EXISTS `Sustitutos` CASCADE
;

DROP TABLE IF EXISTS `Usuarios` CASCADE
;

DROP TABLE IF EXISTS `VentaProductos` CASCADE
;

DROP TABLE IF EXISTS `Ventas` CASCADE
;

CREATE TABLE `Clientes`
(
	`IDClientes` VARCHAR(10) NOT NULL,
	`NombreCliente` VARCHAR(50) NOT NULL,
	`ApellidoPCliente` VARCHAR(50) NOT NULL,
	`ApellidoMCliente` VARCHAR(50) NOT NULL,
	`NumeroTelefono` VARCHAR(10) NOT NULL,
	`Credito` DOUBLE,
	`Domicilio` VARCHAR(100) NOT NULL,
	`CP` VARCHAR(5) NOT NULL,
	CONSTRAINT `PK_Clientes` PRIMARY KEY (`IDClientes`)
)
;

CREATE TABLE `PepsProductos`
(
	`IDProductos` VARCHAR(10) NOT NULL,
	`FechaAbastecimiento` DATETIME(0) NOT NULL,
	`PrecioCosto` DOUBLE NOT NULL,
	`StockLote` INTEGER NOT NULL,
	`PrecioVenta` DOUBLE NOT NULL,
	CONSTRAINT `PK_PepsProductos` PRIMARY KEY (`IDProductos`)
)
;

CREATE TABLE `Productos`
(
	`IDProductos` VARCHAR(10) NOT NULL,
	`NombreProducto` VARCHAR(50) NOT NULL,
	`NombreFamilia` VARCHAR(50),
	`CodigoFamilia` VARCHAR(10),
	`PrecioMayoreo` DOUBLE NOT NULL,
	`Descripcion` VARCHAR(200),
	`MinimoStock` INTEGER NOT NULL,
	`MaximoStock` INTEGER NOT NULL,
	`Datasheet` BLOB,
	`UnidVenta` VARCHAR(50),
	`StockTotal` INTEGER NOT NULL,
	CONSTRAINT `PK_Productos` PRIMARY KEY (`IDProductos`)
)
;

CREATE TABLE `Proveedores`
(
	`IDProveedor` VARCHAR(10) NOT NULL,
	`NombreProveedor` VARCHAR(50) NOT NULL,
	`ApellidoPProveedor` VARCHAR(50) NOT NULL,
	`ApellidoMProveedor` VARCHAR(50) NOT NULL,
	`NumeroTelefono` VARCHAR(10) NOT NULL,
	`EmailProveedor` VARCHAR(50) NOT NULL,
	`NombreEmpresa` VARCHAR(50) NOT NULL,
	`RazonSocial` VARCHAR(10) NOT NULL,
	`Domicilio` VARCHAR(100) NOT NULL,
	`CP` VARCHAR(5) NOT NULL,
	`Descripcion` VARCHAR(200),
	CONSTRAINT `PK_Proveedores` PRIMARY KEY (`IDProveedor`)
)
;

CREATE TABLE `ReportesGeneral`
(
	`IDReporte` VARCHAR(10) NOT NULL,
	`FechaReport` DATETIME(0) NOT NULL,
	`IDVenta` VARCHAR(10) NOT NULL,
	`ArchivoReporte` BLOB,
	CONSTRAINT `PK_ReportesGeneral` PRIMARY KEY (`IDReporte`)
)
;

CREATE TABLE `SurtirInventario`
(
	`IDSurtirInventario` VARCHAR(10) NOT NULL,
	`IDProducto` VARCHAR(10) NOT NULL,
	`IDProveedor` VARCHAR(10) NOT NULL,
	`UnidVenta` VARCHAR(10) NOT NULL,
	`IDProductos` VARCHAR(10),
	CONSTRAINT `PK_SurtirInventario` PRIMARY KEY (`IDSurtirInventario`)
)
;

CREATE TABLE `Sustitutos`
(
	`IDProductos` VARCHAR(10) NOT NULL,
	`NombreSustituto` VARCHAR(50) NOT NULL,
	`TipoSustituto` VARCHAR(20) NOT NULL,
	CONSTRAINT `PK_Sustitutos` PRIMARY KEY (`IDProductos`)
)
;

CREATE TABLE `Usuarios`
(
	`IDUsuarios` VARCHAR(10) NOT NULL,
	`NombreUsuario` VARCHAR(30) NOT NULL,
	`NombrePilaUsuario` VARCHAR(50) NOT NULL,
	`ApellidoPUsuario` VARCHAR(50) NOT NULL,
	`ApellidoMUsuario` VARCHAR(50) NOT NULL,
	`Password` VARCHAR(30),
	CONSTRAINT `PK_Usuarios` PRIMARY KEY (`IDUsuarios`)
)
;

CREATE TABLE `VentaProductos`
(
	`IDVenta` VARCHAR(10) NOT NULL,
	`IDProductos` VARCHAR(10) NOT NULL,
	`Cantidad` INTEGER NOT NULL
)
;

CREATE TABLE `Ventas`
(
	`IDVenta` VARCHAR(10) NOT NULL,
	`FechaVenta` DATETIME(0) NOT NULL,
	`Cantidad` INTEGER NOT NULL,
	`IDClientes` VARCHAR(10) NOT NULL,
	`IDUsuarios` VARCHAR(10) NOT NULL,
	`TotalVentaNeto` DOUBLE NOT NULL,
	`TotalVenta` DOUBLE NOT NULL,
	CONSTRAINT `PK_Ventas` PRIMARY KEY (`IDVenta`)
)
;

ALTER TABLE `PepsProductos` 
 ADD CONSTRAINT `FK_PepsProductos_Productos`
	FOREIGN KEY (`IDProductos`) REFERENCES `Productos` (`IDProductos`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `ReportesGeneral` 
 ADD CONSTRAINT `FK_IDVentas`
	FOREIGN KEY (`IDVenta`) REFERENCES `Ventas` (`IDVenta`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `SurtirInventario` 
 ADD CONSTRAINT `FK_IDProducto`
	FOREIGN KEY (`IDProductos`) REFERENCES `Productos` (`IDProductos`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `SurtirInventario` 
 ADD CONSTRAINT `FK_IDProveedores`
	FOREIGN KEY (`IDProveedor`) REFERENCES `Proveedores` (`IDProveedor`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `Sustitutos` 
 ADD CONSTRAINT `FK_Sustitutos_Productos`
	FOREIGN KEY (`IDProductos`) REFERENCES `Productos` (`IDProductos`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `VentaProductos` 
 ADD CONSTRAINT `FK_IDProductos`
	FOREIGN KEY (`IDProductos`) REFERENCES `Productos` (`IDProductos`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `VentaProductos` 
 ADD CONSTRAINT `FK_IDVentasw`
	FOREIGN KEY (`IDVenta`) REFERENCES  () ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `VentaProductos` 
 ADD CONSTRAINT `FK_VentaProductos_Ventas`
	FOREIGN KEY (`IDVenta`) REFERENCES `Ventas` (`IDVenta`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `Ventas` 
 ADD CONSTRAINT `FK_Ventas_Clientes`
	FOREIGN KEY (`IDClientes`) REFERENCES `Clientes` (`IDClientes`) ON DELETE Restrict ON UPDATE Restrict
;

ALTER TABLE `Ventas` 
 ADD CONSTRAINT `FK_Ventas_Usuarios`
	FOREIGN KEY (`IDUsuarios`) REFERENCES `Usuarios` (`IDUsuarios`) ON DELETE Restrict ON UPDATE Restrict
;

SET FOREIGN_KEY_CHECKS=1
