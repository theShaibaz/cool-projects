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
    <title><?php echo $title; ?></title>

    <script src="<?php echo base_url(); ?>js/lib/jquery/jquery.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/jquery-ui/jquery-ui-new.js"></script>
    <link href="<?php echo base_url(); ?>js/lib/jquery-ui/jquery-ui-new.css" rel="stylesheet">

    <link href="<?php echo base_url(); ?>css/lib/sweetalert/sweetalert.css" rel="stylesheet">
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

<body class="fix-header fix-sidebar">
    <!-- Preloader - style you can find in spinners.css -->
    <div class="preloader">
      <svg class="circular" viewBox="25 25 50 50">
			<circle class="path" cx="50" cy="50" r="20" fill="none" stroke-width="2" stroke-miterlimit="10" /> </svg>
    </div>
    <!-- Main wrapper  -->
    <div id="main-wrapper">
        <!-- header header  -->
        <div class="header">
            <nav class="navbar top-navbar navbar-expand-md navbar-light">
                <!-- Logo -->
                <div class="navbar-header">
                  <!-- Logo icon -->
                  <b><img src="<?php echo base_url(); ?>images/users/graduate.png" style="width:50px;height:45px;" alt="homepage" class="dark-logo" /></b>
                  <!--End Logo icon -->
                  <!-- Logo text -->
                  <span class="navbar-brand"><b>IQRA School</b></span>
                </div>
                <!-- End Logo -->

                <!-- toggle and nav items -->
                <ul class="navbar-nav mr-auto mt-md-0"></ul>
                <!-- User profile and search -->
                <ul class="navbar-nav my-lg-0">
                  <!-- Profile -->
                  <li class="nav-item dropdown">
                    <a class="nav-link dropdown-toggle text-muted  " href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                      <?php
                      if($this->session->username=='admin'||$this->session->username=='sudo'){
                        echo "<img src='".base_url()."images/users/man.png'alt='user' class='profile-pic' />";
                      }
                      elseif ($this->session->username=='user') {
                        echo "<img src='".base_url()."images/users/boy.png'alt='user' class='profile-pic' />";
                      }
                      ?>
                    </a>
                    <div class="dropdown-menu dropdown-menu-right animated zoomIn">
                      <ul class="dropdown-user">
                        <?php
                          if($this->session->username=='admin'||$this->session->username=='sudo'){
                            echo "<li><a href='".base_url()."login/change_password'><i class='fa fa-key'></i> Change Password</a></li>";
                          }
                        ?>
                        <li><a href="<?php echo base_url(); ?>login/logout"><i class="fa fa-power-off"></i> Logout</a></li>
                      </ul>
                    </div>
                  </li>

                </ul>
            </nav>
        </div>
        <!-- End header header -->

        <!-- Left Sidebar  -->
        <div class="left-sidebar">
            <!-- Sidebar scroll-->
            <div class="scroll-sidebar">
                <!-- Sidebar navigation-->
                <nav class="sidebar-nav">
                    <ul id="sidebarnav">
                        <li class="nav-devider"></li>
                        <li class="nav-label">Home</li>
                        <li>
                          <a href="<?php echo base_url(); ?>dashboard" aria-expanded="false"><i class="fa fa-tachometer"></i><span class="hide-menu">Dashboard</span></a>
                        </li>
                        <li class="nav-label">Workspace</li>
                        <li>
                          <a class="has-arrow  " href="#" aria-expanded="false"><i class="fa fa-users"></i><span class="hide-menu">Student</span></a>
                            <ul aria-expanded="false" class="collapse">
                                <li><a href="<?php echo base_url(); ?>student/add_new">Add New</a></li>
                                <li><a href="<?php echo base_url(); ?>student/show_all">Show All</a></li>
                                <?php
                                  if($this->session->username=='admin'||$this->session->username=='sudo'){
                                    echo "<li><a href='".base_url()."student/change_class'>Change Class</a></li>";
                                  }
                                ?>
                            </ul>
                        </li>
                        <li> <a class="has-arrow  " href="#" aria-expanded="false"><i class="fa fa-money"></i><span class="hide-menu">Invoice</span></a>
                            <ul aria-expanded="false" class="collapse">
                                <li><a href="<?php echo base_url(); ?>invoice/create_new">Create New</a></li>
                                <li><a href="<?php echo base_url(); ?>invoice/show_all">Show All</a></li>
                            </ul>
                        </li>
                        <li> <a class="has-arrow  " href="#" aria-expanded="false"><i class="fa fa-exchange"></i><span class="hide-menu">Transaction</span></a>
                            <ul aria-expanded="false" class="collapse">
                                <li><a href="<?php echo base_url(); ?>transaction/add_new">Add New</a></li>
                                <li><a href="<?php echo base_url(); ?>transaction/show_all">Show All</a></li>
                            </ul>
                        </li>
                        <li class="nav-label">Reports</li>
                        <li>
                          <a href="<?php echo base_url(); ?>report" aria-expanded="false"><i class="fa fa-file-pdf-o"></i><span class="hide-menu">Take Reports</span></a>
                        </li>

                        <?php
                          if($this->session->username=='admin'||$this->session->username=='sudo'){
                            echo "<li class='nav-label'>Miscellaneous</li>";
                            echo "<li>";
                            echo "<a href='".base_url()."import' aria-expanded='false'><i class='fa fa-download'></i><span class='hide-menu'>Import Students</span></a>";
                            echo "</li>";
                            echo "<li>";
                            echo "<a href='".base_url()."backup' aria-expanded='false'><i class='fa fa-database'></i><span class='hide-menu'>Backup</span></a>";                            echo "</li>";
                            echo "</li>";
                          }
                        ?>
                    </ul>
                </nav>
                <!-- End Sidebar navigation -->
            </div>
            <!-- End Sidebar scroll-->
        </div>
        <!-- End Left Sidebar  -->


        <!-- Page wrapper  -->
        <div class="page-wrapper">
          <!-- Bread crumb -->
          <div class="row page-titles">
              <div class="col-md-5 align-self-center">
                  <h3 class="text-primary"><?php echo $breadcrumb_1; ?></h3> </div>
              <div class="col-md-7 align-self-center">
                  <ol class="breadcrumb">
                      <li class="breadcrumb-item"><?php echo $breadcrumb_2; ?></li>
                      <li class="breadcrumb-item active"><?php echo $breadcrumb_3; ?></li>
                  </ol>
              </div>
          </div>
          <!-- End Bread crumb -->
          <!-- Container fluid  -->
          <div class="container-fluid">
            <?php $this->load->view($view); ?>
          </div>
          <!-- End Container fluid  -->
        </div>
        <!-- End Page wrapper  -->


    </div>
    <!-- End Wrapper -->

    <!-- All Jquery -->
    <!-- Bootstrap tether Core JavaScript -->
    <script src="<?php echo base_url(); ?>js/lib/bootstrap/js/popper.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/bootstrap/js/bootstrap.min.js"></script>
    <!-- slimscrollbar scrollbar JavaScript -->
    <script src="<?php echo base_url(); ?>js/jquery.slimscroll.js"></script>
    <!--Menu sidebar -->
    <script src="<?php echo base_url(); ?>js/sidebarmenu.js"></script>
    <!--stickey kit -->
    <script src="<?php echo base_url(); ?>js/lib/sticky-kit-master/dist/sticky-kit.min.js"></script>
    <!--Custom JavaScript -->
    <script src="<?php echo base_url(); ?>js/scripts.js"></script>
    <!-- Toastr -->
    <script src="<?php echo base_url(); ?>js/lib/toastr/toastr.min.js"></script>
    <!-- scripit init-->
    <script src="<?php echo base_url(); ?>js/lib/toastr/toastr.init.js"></script>

    <!-- Form validation -->
    <!-- <script src="js/lib/form-validation/jquery.validate.min.js"></script>
    <script src="js/lib/form-validation/jquery.validate-init.js"></script> -->

    <script src="<?php echo base_url(); ?>js/lib/sweetalert/sweetalert.min.js"></script>
    <!-- scripit init-->
    <script src="<?php echo base_url(); ?>js/lib/sweetalert/sweetalert.init.js"></script>

    <!-- Data Table -->
    <script src="<?php echo base_url(); ?>js/lib/datatables/datatables.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/dataTables.buttons.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.flash.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdnjs.cloudflare.com/ajax/libs/jszip/2.5.0/jszip.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/pdfmake.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.rawgit.com/bpampuch/pdfmake/0.1.18/build/vfs_fonts.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.html5.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/cdn.datatables.net/buttons/1.2.2/js/buttons.print.min.js"></script>
    <script src="<?php echo base_url(); ?>js/lib/datatables/datatables-init.js"></script>

    <!-- Custom JavaScript -->
    <script src="<?php echo base_url(); ?>js/custom.min.js"></script>

</body>

</html>
