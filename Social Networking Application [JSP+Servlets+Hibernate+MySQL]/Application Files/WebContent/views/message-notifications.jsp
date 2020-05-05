<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1" %>

<%@page import="com.mutiny.dao.UserDao"%>

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
        
        <div class="container">
            <div class="container-fluid">
                        	<div class="row">
                        		<div class="col-lg-10 offset-sm-1">
		                        <%
		                        
		                        if(messageNotifications.size() > 0){
									
									
									out.println("<div class=\"card\">");
									out.println("<div class=\"card-title\">");
									out.println("Your Message Notifications");
									out.println("<div class=\"float-right\">");
									out.println("<a href=\"/Mutiny-JSP-Hibernate/NotificationController?action=readMessageNotifications\">");
									out.println("<button type=\"submit\" id=\"login\" class=\"btn btn-primary btn-flat float-right\">Clear All</button>");
									out.println("</a>");
									out.println("</div>");
									out.println("</div>");
									out.println("</div>");
									
									for(Notification notification : messageNotifications){
										
										int notificationId = notification.getNotificationId();
										String text = notification.getNotificationText();
	                               		String date = HelperController.epochToDate(notification.getNotificationDate());
	                                  	int otherUserId = notification.getOtherUserId().getUserId();
										String notificationType = notification.getNotificationType().getTypeName();
	                                  	String picture = UserController.getProfilePicture(otherUserId);
	                                  	String name = UserDao.getUsername(otherUserId);
										
										
										out.println("<div class=\"card\">");
										out.println("<div class=\"card-body\">");
	                                 	out.println("<div class=\"recent-comment\">");
	                					out.println("<div class=\"media\">");
	                					out.println("<div class=\"media-left\">");
	                					
	                					if(notificationType.equalsIgnoreCase("Private Message")){
											out.println("<a href=\"/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&notificationId=" + notificationId + "&page=privateChat&otherUserId=" + otherUserId + "\">");
	                					}
	                					else if(notificationType.equalsIgnoreCase("Community Message")){
	                						
	                						String communityName = text.substring(text.indexOf("\"") + 1, text.lastIndexOf("\""));
	                						int communityId = CommunityDao.getCommunity(communityName).getCommunityId();
											out.println("<a href=\"/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&notificationId=" + notificationId + "&page=communityChat&communityId=" + communityId + "\">");
	                					}
	                					
										out.println("<img alt=\"...\" src=\"" + picture + "\" class=\"media-object\">");
	                					out.println("</div>");
	                					out.println("<div class=\"media-body\">");
	                					out.println("<h4 class=\"media-heading\">" + name + "</h4>");
	                					out.println("<p>" + text + "</p>");
	                					out.println("<p class=\"comment-date\">" + date + "</p>");
	                					out.println("</a>");
	                					out.println("</div>");
	                					out.println("</div>");
	                					out.println("</div>");
	                					out.println("</div>");
	                					out.println("</div>");
									}
								}
								else{
									
									out.println("<div class=\"card\">");
									out.println("<div class=\"card-title\">");
									out.println("No Message Notifications");
									out.println("</div>");
									out.println("</div>");
									out.println("");
									out.println("");
								}
		                        
									

		                        %>
		                        
		                        </div>
                <br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>

            </div>
        </div>
        <!-- End PAge Content -->
    </div>
    <!-- End Container fluid  -->
    <!-- footer -->

    <!-- End footer -->
    </div>
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

</body>

</html>