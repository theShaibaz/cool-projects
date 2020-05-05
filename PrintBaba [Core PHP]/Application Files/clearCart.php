<?php

error_reporting(0);
session_start();

    $order=$_SESSION['order'];
    $total=$_SESSION['total'];
    $total_fees=$_SESSION['total_fees'];

    $order="";
    $total=0;
    $total_fees=0;

    $_SESSION['order']=$order;
    $_SESSION['total']=$total;
    $_SESSION['total_fees']=$total_fees;

session_destroy();

    header("Location:http://localhost/PrintBaba/browse.php");

?>