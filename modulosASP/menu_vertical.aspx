<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_vertical.aspx.cs" Inherits="modulosASP.menu_vertical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
   <meta name="viewport" content="width=device-width, initial-scale=1">
  <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/css/bootstrap.min.css">
  <script src="https://cdn.jsdelivr.net/npm/jquery@3.6.0/dist/jquery.slim.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"></script>
  <script src="https://cdn.jsdelivr.net/npm/bootstrap@4.6.1/dist/js/bootstrap.bundle.min.js"></script>

    <title>Menu Inicio</title>
</head>
<body> 
    <style>
        .borde{
            border:1px solid green;
        }

        .columna{
            border:1px inset blue;
        }
    </style>
    <div class="container-fluid"><!---contenedor principal-->
        
        <div class="row borde">
            <div class="col">
                Barra de navegacion
            </div>
        </div>

        <div class="row borde"><!--inicio de la fila y uso de dos columnas-->
            <div class="col columna">
                Row 1 Col 1
            </div>

            <div class="col columna">
                Row 1 Col 2
            </div><!--Fin de la fila y uso de dos columnas-->
        </div>

        <div class="row borde">
            <div class="col columna">
                Row 2 col 1
            </div>
        </div>


    </div><!---fin del contenedor principal-->
    
    
</body>
</html>
