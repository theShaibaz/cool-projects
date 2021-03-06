<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1" %>
<%@page import="com.mutiny.controllers.FriendController"%>
<%@page import="com.mutiny.models.Friend"%>
<%@page import="com.mutiny.dao.FriendDao"%>

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
    <link rel="icon" type="image/png" sizes="16x16" href="images/logo/logo.jpg">
    <%
		
		String uname = HelperController.getUsername(session);
	
	%>
	<title>Mutiny | <%= uname %></title>
    <link href="css/lib/chartist/chartist.min.css" rel="stylesheet">
    <link href="css/lib/owl.carousel.min.css" rel="stylesheet" />
    <link href="css/lib/owl.theme.default.min.css" rel="stylesheet" />
    <!-- Bootstrap Core CSS -->
    <link href="css/lib/bootstrap/bootstrap.min.css" rel="stylesheet">
    <!-- Custom CSS -->
    <link href="css/helper.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
    <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WARNING: Respond.js doesn't work if you view the page via file:** -->
    <!--[if lt IE 9]>
    <script src="https:**oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js"></script>
    <script src="https:**oss.maxcdn.com/libs/respond.js/1.4.2/respond.min.js"></script>
<![endif]-->
</head>

<body class="fix-header fix-sidebar" style="background-color: cadetblue;">
    <!-- Preloader - style you can find in spinners.css -->
    <div class="preloader">
        <svg class="circular" viewBox="25 25 50 50">
            <circle class="path" cx="50" cy="50" r="20" fill="none" stroke-width="2" stroke-miterlimit="10" /> </svg>
    </div>
    <!-- Main wrapper  -->
    <div id="main-wrapper">
         
         <%@ include file="navbar.jsp" %>
         
         <%
         
         	List<Friend> friends = FriendDao.getFriends(userId);
         
         %>
         
        <div class="container">
            <div class="container-fluid">

                <div class="row">
                    <div class="col-lg-10 offset-sm-1">
                        <div class="card">
                            <div class="card-title">



                            </div>

                            <div class="card-body">

                                <br>
                                
                                <%
                                
                                out.println("<form action=\"/Mutiny-JSP-Hibernate/CommunityController?action=addCommunity\" enctype=\"multipart/form-data\" method=\"post\">");
                                
                                %>
                                
                                <div class="form-group">
                                    <div class="form-group row">
                                        <div class="col-lg-6 offset-md-3">
                                            <!-- <label>Choose file to post</label> -->
                                            <input type="text" class="form-control" id="communityName" name="communityName"
                                                placeholder="Enter name of community" />
                                        </div>
                                    </div>
                                    <br>
                                    <div class="form-group row">
                                        <div class="col-lg-6 offset-md-3">
                                            <!-- <label>Choose file to post</label> -->
                                            <input type="text" class="form-control" id="description" name="description"
                                                placeholder="Enter description" />
                                        </div>
                                    </div>
                                    <br>
                                    <div class="form-group row">
                                        <div class="col-lg-6 offset-md-3">
                                            <!-- <label>Password</label> -->
                                            <input type="file" class="form-control" id="communityPicture" name="communityPicture"
                                                placeholder="" accept="image/*" />
                                        </div>
                                    </div>

                                    <div class="form-group row">
                                        <div class="col-lg-6 offset-md-3">
                                            <!-- <label>Multiple Select</label> -->
                                            <select name="friends" multiple class="form-control" style="height: 150px;">
                                            <%
                                            
                                            	for(Friend friend : friends){
                                            		
                                            		int friendId = friend.getFriendId().getUserId();
                                            		String friendUsername = friend.getFriendId().getUsername();
                                            		
                                            		out.println("<option value=\"" + friendId + "\">" + friendUsername + "</option>");
                                            	}
                                            %>
                                            </select>
                                            
                                           
                                            
                                        </div>
                                    </div>

									<%
									
										String disabled = "";
									    String cl = "";
										if(friends.size() < 1){
											disabled = "disabled";
											cl = "btn btn-flat offset-md-6";
										}
										else{
											cl = "btn btn-primary btn-flat offset-md-6";
										}
									%>
									<button type="submit" id="login" class="<%= cl %>" <%= disabled %>>
                                        Create Community
                                    </button>
                                    
                                  <%
                                  
                                  	out.println("</form>");
                                  
                                  %>
                                  
                                    
                                </div>

                                <br>




                            </div>




                        </div>
                    </div>
                </div>


                <br><br><br><br><br><br><br><br><br><br><br><br>


            </div>
        </div>
        <!-- End PAge Content -->
    </div>
    <!-- End Container fluid  -->
    <!-- footer -->

    <!-- End footer -->
    <!-- End Page wrapper  -->
    
    
    
    
    <!-- End Wrapper -->
    <!-- All Jquery -->
    <script src="js/lib/jquery/jquery.min.js"></script>
    <!-- Bootstrap tether Core JavaScript -->
    <script src="js/lib/bootstrap/js/popper.min.js"></script>
    <script src="js/lib/bootstrap/js/bootstrap.min.js"></script>
    <!-- slimscrollbar scrollbar JavaScript -->
    <script src="js/jquery.slimscroll.js"></script>
    <!--Menu sidebar -->
    <script src="js/sidebarmenu.js"></script>
    <!--stickey kit -->
    <script src="js/lib/sticky-kit-master/dist/sticky-kit.min.js"></script>


    <!--Custom JavaScript -->
    <script src="js/custom.min.js"></script>

	<script type="text/javascript">

		/*$("#memberIds").change(function(){

			var array = $("#memberIds").val();
			var ids = array.join(",");
			$("#memberIds").val(ids);
		});*/
    
    </script>


</body>

</html>