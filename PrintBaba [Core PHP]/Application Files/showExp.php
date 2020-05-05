<?php

error_reporting(0);
session_start();

$sub=$_POST['sub'];
$_SESSION['sub']=$sub;
header("Location:http://localhost/PrintBaba/browse.php");

?>
