## Crear un Proyecto Nuevo
    dotnet new mvc -n webmvc

    dotnet restore

    dotnet run


## Comandos Docker para crear una BD de MySQL

	docker run --name srv-mysql -e MYSQL_ROOT_PASSWORD=master -e MYSQL_DATABASE=prueba -p 3306:3306 -d mysql:5.7.28 

## Tablas de MySQL

	
	CREATE TABLE region(
		cod_region INT NOT NULL,
		nombre VARCHAR(130),
		PRIMARY KEY (cod_region)
	);

	INSERT INTO region(cod_region, nombre) values(1,'Norte');
	INSERT INTO region(cod_region, nombre) values(2,'Sur');
	INSERT INTO region(cod_region, nombre) values(3,'Este');
	INSERT INTO region(cod_region, nombre) values(4,'Oeste');

## Librerias que agregar al proyecto de .net core

	dotnet add package Microsoft.EntityFrameworkCore.SqlServer
	dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
	dotnet add package Microsoft.EntityFrameworkCore.Design
	dotnet tool install --global dotnet-aspnet-codegenerator

## Comandos de asp codegenerator
	
	dotnet aspnet-codegenerator controller -name RegionesController -actions -nv -m Region -dc Contexto -outDir Controllers

	dotnet aspnet-codegenerator view Index List -outDir Views/Regiones -udl -m Region
	dotnet aspnet-codegenerator view Create Create -outDir Views/Regiones -udl -m Region
	dotnet aspnet-codegenerator view Edit Edit -outDir Views/Regiones -udl -m Region
	dotnet aspnet-codegenerator view Details Details -outDir Views/Regiones -udl -m Region
	dotnet aspnet-codegenerator view Delete Delete -outDir Views/Regiones -udl -m Region