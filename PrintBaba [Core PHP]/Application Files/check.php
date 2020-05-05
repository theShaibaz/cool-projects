<?php
    error_reporting(0);
    $con=mysql_connect("localhost","root","") or die("Could not connect to server");
    $db_name = "PrintBaba";
    mysql_select_db($db_name,$con) or die("Could not open Database");

    $date=$_GET['date'];
    $query="select * from orders where Date='$date'";
    $result=mysql_query($query);
    $count=mysql_num_rows($result);
    $c=0;

    echo"<table border=1 cellspacing=1 cellpadding=5>";
    echo"<tr><td>PSN</td><td>Date</td><td>Name</td><td>Mobile</td><td>Order</td><td>Cost</td><td>Fees</td></tr>";
    while($c<$count)
    {
        echo"<tr>";
        echo"<td>".mysql_result($result,$c,"PSN")."</td>";
        echo"<td>".mysql_result($result,$c,"Date")."</td>";
        echo"<td>".mysql_result($result,$c,"Name")."</td>";
        echo"<td>".mysql_result($result,$c,"Mobile")."</td>";
        echo"<td>".mysql_result($result,$c,"Particulars")."</td>";
        echo"<td>".mysql_result($result,$c,"Cost")."</td>";
        echo"<td>".mysql_result($result,$c,"Fees")."</td>";
        echo"</tr>";
        $c++;
    }
?>