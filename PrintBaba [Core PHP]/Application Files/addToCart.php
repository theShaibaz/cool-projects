<?php

error_reporting(0);
session_start();

    $con=mysql_connect("localhost","root","") or die("Could not connect to server");
    $db_name = "PrintBaba";
    mysql_select_db($db_name,$con) or die("Could not open Database");

    $sub=$_POST['sub'];
    $exp=$_POST['exp'];
    $qty=$_POST['qty'];

    $query="select Rate from Experiments where Subject_Name='$sub' and Experiment_Name='$exp'";
    $result=mysql_query($query);
    $res_count=mysql_num_rows($result);

    $rate=mysql_result($result,0,"Rate");

    $order=$_SESSION['order'];
    $total=$_SESSION['total'];
    $order=$order . " #[" . $sub . ": " . $exp . ", " . $qty . " Set, Rs." . $rate ."/Set]";
    $total=$total+($rate*$qty);
    $_SESSION['order']=$order;
    $_SESSION['total']=$total;

    $query="select Fees from Experiments where Subject_Name='$sub' and Experiment_Name='$exp'";
    $result=mysql_query($query);
    $res_count=mysql_num_rows($result);

    $fees=mysql_result($result,0,"Fees");

    $total_fees=$_SESSION['total_fees'];
    $total_fees=$total_fees+($fees*$qty);
    $_SESSION['total_fees']=$total_fees;

    //echo" ".$order;
    //echo" TOTAL   ".$total. " TOTAL_FEES " . $total_fees . " # ";

    header("Location:http://localhost/PrintBaba/browse.php");

?>