<!DOCTYPE html>
<html lang="en">

<head>

    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <!-- Tell the browser to be responsive to screen width -->
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <meta name="description" content="">
    <meta name="author" content="">
    <!-- Favicon icon -->
    <link rel="icon" type="image/png" sizes="16x16" href="<?php echo base_url(); ?>images/users/graduate.png">
    <title>IQRA | Login</title>

    <link href="<?php echo base_url(); ?>css/lib/toastr/toastr.min.css" rel="stylesheet">
    <!-- Bootstrap Core CSS -->
    <link href="<?php echo base_url(); ?>css/lib/bootstrap/bootstrap.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="<?php echo base_url(); ?>css/helper.css" rel="stylesheet">
    <link href="<?php echo base_url(); ?>css/style.css" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:** -->
    <!--[if lt IE 9]>
    <script src="https:**oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https:**oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
</head>

<body class="fix-header fix-sidebar"
style="background:url('<?php echo base_url(); ?>images/users/education.jpg')
      no-repeat center center fixed;
      -webkit-background-size: cover;
      -moz-background-size: cover;
      -o-background-size: cover;
      background-size: cover;
      height:662px;">

    <!-- Preloader - style you can find in spinners.css -->
    <div class="preloader">
        <svg class="circular" viewBox="25 25 50 50">
			<circle class="path" cx="50" cy="50" r="20" fill="none" stroke-width="2" stroke-miterlimit="10" /> </svg>
    </div>
    <!-- Main wrapper  -->
    <div id="main-wrapper">

        <div class="unix-login">
            <div class="container-fluid">
                <div class="row justify-content-center">
                    <div class="col-lg-4">
                        <div class="login-content card">
                          <div class="form-validation">
                            <div class="login-form">
                                <h4>Login</h4>
                                <form class="form-valide" action="<?php echo base_url(); ?>login/authenticate" method="post">
                                  <div class="form-group ">
                                      <div class="col-lg-12">
                                          <input type="text" class="form-control" id="username" name="username" placeholder="Username">
                                      </div>
                                  </div>
                                  <div class="form-group ">
                                      <div class="col-lg-12">
                                          <input type="password" class="form-control" id="password" name="password" placeholder="Password">
                                      </div>
                                  </div>

                                  <div class="form-group col-lg-12">
                                      <button type="submit" id="login" class="btn btn-primary btn-flat m-b-30 m-t-30">Log in</button>
                                  </div>
                                </form>
                            </div>
                          </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <!-- End Wrapper -->

    <!-- All Jquery -->
    <script src="<?php echo base_url(); ?>js/lib/jquery/jquery.min.js"></script>

    <!-- Bootstrap tether Core JavaScript -->
    <script src="<?php echo base_url(); ?>js/lib/bootstrap/js/popper.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/bootstrap/js/bootstrap.min.js"></script>
    <!-- slimscrollbar scrollbar JavaScript -->
    <script src="<?php echo base_url(); ?>js/jquery.slimscroll.js"></script>
    <!--Menu sidebar -->
    <script src="<?php echo base_url(); ?>js/sidebarmenu.js"></script>
    <!--stickey kit -->
    <script src="<?php echo base_url(); ?>js/lib/sticky-kit-master/dist/sticky-kit.min.js"></script>

    <!-- Form validation -->
    <!-- <script src="<?php echo base_url(); ?>js/lib/form-validation/jquery.validate.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/form-validation/jquery.validate-init.js"></script> -->

    <!-- Toastr -->
    <script src="<?php echo base_url(); ?>js/lib/toastr/toastr.min.js"></script>
    <!-- scripit init-->
    <script src="<?php echo base_url(); ?>js/lib/toastr/toastr.init.js"></script>
    <!--Custom JavaScript -->
    <script src="<?php echo base_url(); ?>js/custom.min.js"></script>

    <?php

      // Showing toastr message box
      if($this->input->cookie('message_code')==3){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "warning('Enter username and password','Check Input');";
        echo "});";
        echo "</script>";
      }
      if($this->input->cookie('message_code')==4){
        echo "<script>";
        echo "$(document).ready(function(){";
        echo "error('Enter correct credentials','Login Failed');";
        echo "});";
        echo "</script>";
      }
    ?>

</body>

</html>
