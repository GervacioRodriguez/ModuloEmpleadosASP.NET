<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="menu_vertical.aspx.cs" Inherits="modulosASP.menu_vertical" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
     <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

    <title></title>
</head>
<body> 
    
    <form id="form1">
        <div class =" containe">
            <div class="row">
                <div class="col-sm-3">
                    <!--Aquí se colocoaran los botones-->
                        <p>hola mundo</p>   
                    <div class ="btn-group-vertical">
                        <a href="#" class="btn btn-dark" role="button">Usuario</a>
                        <a href="#" class="btn btn-dark" role="button">Agregar empleado</a>
                        <a href="#" class="btn btn-dark" role="button">Elementos</a>
                        <a href="#" class="btn btn-dark" role="button">Equipos</a><div></div>
                    </div>
                </div>
                <div class ="col-sm-9">
                    <div class="pantalla">
                        <!--Aquí se usara para mostrara datos si necesidad de recargar datos usando jquery-->
                        <p>menu desplegable</p>
                    </div>
                </div>
            </div>
        </div>            


    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>
