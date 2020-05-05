<?php
header("Location:http://smszone.in/sendsms.asp?page=SendSmsBulk&username=**********&password=**********&number=".$_SESSION['mobile']."&message=".$_SESSION['msg']);
?>
