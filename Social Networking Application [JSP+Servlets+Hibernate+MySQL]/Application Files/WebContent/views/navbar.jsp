<%@page import="com.mutiny.dao.CommunityDao"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1" %>

<%@ page import="java.util.List" %>
<%@ page import="java.util.Date" %>
<%@ page import="java.util.ArrayList" %>
<%@ page import="com.mutiny.models.Notification" %>
<%@ page import="com.mutiny.models.Community" %>
<%@ page import="com.mutiny.dao.PostHolder" %>
<%@ page import="com.mutiny.dao.NotificationDao" %>
<%@ page import="com.mutiny.controllers.UserController" %>
<%@ page import="com.mutiny.controllers.PostController" %>
<%@ page import="com.mutiny.controllers.NotificationController" %>
<%@ page import="com.mutiny.controllers.HelperController"%>

		<%
  	
			//session.setAttribute("userId", 1);
			//session.setAttribute("username", "Alex");
			
			int userId = HelperController.getUserId(session);
			String username = HelperController.getUsername(session);
			
			List<Notification> notifications = NotificationDao.getNotifications(userId);
			List<Notification> messageNotifications = NotificationDao.getMessageNotifications(userId);
			
			String profilePicture = UserController.getProfilePicture(userId);
	
   		%>
    
        <!-- header header  -->
        <div class="header">
            <nav class="navbar top-navbar navbar-expand-md navbar-light" style="background-color: aliceblue;">
            
                <!-- Logo -->
                <div class="navbar-header" style="background-color: aliceblue;">
                    <a class="navbar-brand" href="user-home.jsp">
                        <!-- Logo icon -->
                        <b><img src="images/logo/logo.jpg" style="width:75px;height:70px;" alt="homepage" class="dark-logo" /></b>
                        <!--End Logo icon -->
                    </a>
                </div>
                <!-- End Logo -->
                
                <div class="navbar-collapse">
                    <!-- User profile and search -->
                    <ul class="navbar-nav my-lg-0 offset-md-10">

                        <!-- Search -->
                        <li class="nav-item hidden-sm-down search-box">
                        	<a class="nav-link hidden-sm-down text-muted" href="javascript:void(0)"><i class="ti-search"></i></a>
                            <form class="app-search" action="/Mutiny-JSP-Hibernate/UserController?action=searchUsers" method="post">
                                <input type="text" class="form-control" placeholder="Search here" name="username"> 
                                	<a class="srh-btn"><i class="ti-close"></i></a> 
                            </form>
                        </li>

                        <!-- Comment -->
                        <li class="nav-item dropdown">
                            <a class="nav-link dropdown-toggle text-muted text-muted" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                            	<i class="fa fa-bell"></i>
                                <div class="notify">
                                
                                	<%
                                	
	                                    if(notifications.size() > 0){
	                                    	out.println("<span class=\"point\"></span>");
	                                    }
                                	
                                 	%>
                                 	
                                </div>
                            </a>
                            <div class="dropdown-menu dropdown-menu-right mailbox animated zoomIn">
                                <ul>
	
									<%

                                    	if(notifications.size() > 0){

	                                    	out.println("<li><div class=\"drop-title\">" + notifications.size() + " new notifications</div></li>");
	
	                                    	int count = 0;
	
	                                    	for(Notification notification : notifications){
	
		                                    	if(++count < 4){ 
		                                    	
		                                    		int otherUserId = notification.getOtherUserId().getUserId();
			                                        String path = UserController.getProfilePicture(otherUserId);
		                                    		String text = notification.getNotificationText();
			                                        String date = HelperController.epochToDate(notification.getNotificationDate());
			                                        String picture = UserController.getProfilePicture(otherUserId);
			                                        String notificationType = notification.getNotificationType().getTypeName();
			                                        int notificationId = notification.getNotificationId();
			                                        
			                                    	out.println("<li>");
			                                        out.println("<div class=\"slimScrollDiv\" style=\"position: relative; overflow:visible hidden; width: auto; height: 60px;\">");
		                                            out.println("<div class=\"message-center\">");
		                                            
		                                            String action = "";
		                                            if(notificationType.equalsIgnoreCase("Friend Request")){
		                                            	
		                                            	action = "/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&page=friendRequests&notificationId=" + notificationId;
		                                            }
		                                            else  if(notificationType.equalsIgnoreCase("Request Accept")){
		                                            	
		                                            	action = "/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&page=userProfile&profileId=" + otherUserId + "&notificationId=" + notificationId;
		                                            }
		                                            else  if(notificationType.equalsIgnoreCase("Added to Community")){
		                                            	
		                                            	String communityName = text.substring(text.indexOf("\"") + 1, text.lastIndexOf("\""));
		                                            	int communityId = CommunityDao.getCommunityId(communityName);
		                                            	action = "/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&page=communityChat&communityId=" + communityId + "&notificationId=" + notificationId;
		                                            }
		                                            
		                                            out.println("<a href=\"" + action + "\">");
		                                            out.println("<div class=\"user-img\">");
		                                            out.println("<img src='" + picture + "' alt=\"user\" class=\"img-circle\" />");
		                                            out.println("</div>");
		
		                                            out.println("<div class=\"mail-contnet\">");
		                                            out.println("<span class=\"mail-desc\">" + text + "</span>");
		                                            out.println("<span class=\"time\">" + date + "</span>");
		                                            out.println("</div></a></div></div></li>");
		                        				}
		                        				else{
		                        					break;
		                        				}
	                        				}

					                        out.println("<li>");
					                        out.println("<a class=\"nav-link text-center\" href=\"notifications.jsp\">");
					                        out.println("<strong>Check all notifications</strong>");
					                        out.println("<i class=\"fa fa-angle-right\"></i>");
					                        out.println("</a>");
					                        out.println("</li>");
                        				}
                        				else{
                        					out.print("<li><div class=\"drop-title\">No new notifications</div></li>");
                       		 			}
                        			%>
                    	
                    		</ul>
                		</div>
                	</li>
                <!-- End Comment -->
                
                <!-- Messages -->
                <li class="nav-item dropdown">
                
                    <a class="nav-link dropdown-toggle text-muted" href="#" id="2" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false"> 
                    	<i class="fa fa-envelope"></i>
                        <div class="notify">
                        
                        	<%
                                	
	                        	if(messageNotifications.size() > 0){
	                            	out.println("<span class=\"point\"></span>");
	                            }
                                	
                            %>
                        
                        </div>
                    </a>
                    
                    <div class="dropdown-menu dropdown-menu-right mailbox animated zoomIn" aria-labelledby="2">
                        <ul>
                        
                        	<%

                               	if(messageNotifications.size() > 0){

	                            	out.println("<li><div class=\"drop-title\">" + messageNotifications.size() + " new messages</div></li>");
	
	                            	int count = 0;
	
	                            	for(Notification notification : messageNotifications){
	
		                            	if(++count < 4){ 
		                                    	
		                            		String text = notification.getNotificationText();
		                               		String date = HelperController.epochToDate(notification.getNotificationDate());
		                                  	int otherUserId = notification.getOtherUserId().getUserId();
		                                 	String path = UserController.getProfilePicture(otherUserId);
		                                 	String picture = UserController.getProfilePicture(otherUserId);
		                                 	String notificationType = notification.getNotificationType().getTypeName();
		                                 	int notificationId = notification.getNotificationId();
		                                 	
			                            	out.println("<li>");
			                            	out.println("<div class=\"slimScrollDiv\" style=\"position: relative; overflow:visible hidden; width: auto; height: 60px;\">");
		                                	out.println("<div class=\"message-center\">");
		                                	
		                                	String action = "";
                                            if(notificationType.equalsIgnoreCase("Private Message")){
                                            	
                                            	action = "/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&page=privateChat&otherUserId=" + otherUserId + "&notificationId=" + notificationId;
                                            }
                                            else if(notificationType.equalsIgnoreCase("Community Message")){
                                            	
                                            	String communityName = text.substring(text.indexOf("\"") + 1, text.lastIndexOf("\""));
                                            	int communityId = CommunityDao.getCommunityId(communityName);
                                            	action = "/Mutiny-JSP-Hibernate/NotificationController?action=readNotification&page=communityChat&communityId=" + communityId + "&notificationId=" + notificationId;
                                            }
		                                	
		                                 	out.println("<a href=\"" + action + "\">");
		                                 	out.println("<div class=\"user-img\">");
		                                  	out.println("<img src='" + picture + "' alt=\"user\" class=\"img-circle\" />");
		                                  	out.println("</div>");
		
		                                   	out.println("<div class=\"mail-contnet\">");
		                                  	out.println("<span class=\"mail-desc\">" + text + "</span>");
		                                  	out.println("<span class=\"time\">" + date + "</span>");
		                                	out.println("</div></a></div></div></li>");
		                        		}
		                        		else{
		                        			break;
		                        		}
	                        		}

					                out.println("<li>");
					               	out.println("<a class=\"nav-link text-center\" href=\"message-notifications.jsp\">");
					              	out.println("<strong>Check all message notifications</strong>");
					              	out.println("<i class=\"fa fa-angle-right\"></i>");
					              	out.println("</a>");
					              	out.println("</li>");
                        		}
                      			else{
                        			out.print("<li><div class=\"drop-title\">No new messages</div></li>");
                       		 	}
                        			
                        	%>
                        
                        </ul>
                    </div>
                </li>
                <!-- End Messages -->
                <!-- Profile -->
                <li class="nav-item dropdown">
                
                    <a class="nav-link dropdown-toggle text-muted" href="#" data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                        <img src="<%= profilePicture %>" alt="user" class="profile-pic" />
                    </a>
                    
                    <div class="dropdown-menu dropdown-menu-right animated zoomIn">
                        <ul class="dropdown-user">
                            <li>
                            	<a href="/Mutiny-JSP-Hibernate/UserController?action=showUserProfile&profileId=<%= userId %>">
                            		<i class="fa fa-user-circle-o"></i>&nbsp;&nbsp;<%= username %></a>
                            </li>
                            <li>
                            	<a href="text-post.jsp"><i class="fa fa-paragraph"></i>&nbsp;&nbsp;&nbsp;Text Post</a>
                            </li>
                            <li>
                            	<a href="media-post.jsp"><i class="fa fa-camera-retro"></i>&nbsp;&nbsp;Image Post</a>
                            </li>
                            <li>
                            	<a href="video-post.jsp"><i class="fa fa-video-camera"></i>&nbsp;&nbsp;Video Post</a>
                            </li>
                             <li>
                            	<a href="message-list.jsp"><i class="fa fa-envelope"></i>&nbsp;&nbsp;Messages</a>
                            </li>
                            <li>
                            	<a href="friend-requests.jsp"><i class="fa fa-user-plus"></i>&nbsp;&nbsp;Friend Requests</a>
                            </li>
                            <li>
                            	<a href="create-community.jsp"><i class="fa fa-users"></i>&nbsp;&nbsp;Create Community</a>
                            </li>
                            <li>
                            	<a href="/Mutiny-JSP-Hibernate/LoginController?action=logout"><i class="fa fa-sign-out"></i>&nbsp;&nbsp;Logout</a>
                            </li>
                        </ul>
                    </div>
                </li>
                </ul>
        </div>
        </nav>
    </div>