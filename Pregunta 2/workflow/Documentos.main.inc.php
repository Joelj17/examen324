<?php
session_start();
echo "Hola: ".$_SESSION["id"]; 
echo "<br>";

$sql="select * from elec.candidatos where id=".$_SESSION["id"];
$resultado=mysqli_query($con, $sql);
$fila=mysqli_fetch_array($resultado);

$nombrecompleto=$fila["nombrecompleto"];

?>