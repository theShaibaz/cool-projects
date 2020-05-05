<%@page import="com.mutiny.controllers.CommunityController"%>
<%@page import="com.mutiny.dao.FriendDao"%>
<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1" %>

<%@page import="com.mutiny.controllers.FriendController"%>
<%@page import="com.mutiny.dao.UserDao"%>
<%@page import="com.mutiny.dao.PostDao"%>
<%@page import="com.mutiny.models.Friend"%>

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
		
			int profileId = (int)session.getAttribute("profileId");
			String picture = UserController.getProfilePicture(profileId);
			String name = UserDao.getUsername(profileId);
		
		%>

        <div class="container">
            <div class="container-fluid">

                <div class="row">

                    <div class="col-lg-12">
                        <div class="card">
                            <div class="card-body">
                                <div class="card-two">
                                    <header>
                                        <div class="avatar">
                                        	
                                        	<%
                                        	
                                        		out.println("<img src=\"" + picture + "\" alt=\"" + name + "\" />");
                                        	
                                        	%>
                                        
                                            
                                        </div>
                                    </header>

                                    <h3><%= name %></h3>
                                    <div class="desc">
                                        <%= UserDao.getUserStatus(profileId) %>
                                    </div>
                                    
                                    
                                    <%
                                    
                                    	if(userId != profileId && FriendDao.areFriends(userId, profileId)){
                                    		
                                    		out.println("<a href=\"/Mutiny-JSP-Hibernate/UserController?action=privateChat&otherUserId=" + profileId + "\">");
                                    		out.println("<button type=\"submit\" id=\"login\" class=\"btn btn-primary btn-flat offset-md-5\" style=\"margin-left:45%\">Message</button>");
                                    		out.println("</a>");
                                    	}
                                    	else if(userId != profileId && !FriendDao.areFriends(userId, profileId)){
                                    		
                                    		if(UserDao.isRequestSent(userId, profileId)){
                                    			
                                        		out.println("<button type=\"submit\" id=\"login\" class=\"btn btn btn-flat offset-md-5\" style=\"margin-left:43%\" disabled>Request Sent</button>");
                                    		}
                                    		else{
                                    			
                                    			out.println("<a href=\"/Mutiny-JSP-Hibernate/FriendController?action=addFriendRequest&page=userProfile&toUserId=" + profileId + "\">");
                                        		out.println("<button type=\"submit\" id=\"login\" class=\"btn btn-primary btn-flat offset-md-5\" style=\"margin-left:43%\">Send Request</button>");
                                        		out.println("</a>");
                                    		}
                                    		
                                    	}
                                    
                                    %>
                                    
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class="col-lg-12">
                        <div class="card">
                            <!-- Nav tabs -->
                            <ul class="nav nav-tabs profile-tab" role="tablist">
                                <li class="nav-item"> <a class="nav-link active" data-toggle="tab" href="#timeline"
                                        role="tab">Timeline</a> </li>
                                <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#friends"
                                        role="tab">Friends</a> </li>
                                <li class="nav-item"> <a class="nav-link" data-toggle="tab" href="#communities"
                                        role="tab">Communities</a> </li>
                                        
                                 <%
                                 
                                 	if(userId == profileId){
                                 		
                                 		out.println("<li class=\"nav-item\"> <a class=\"nav-link\" data-toggle=\"tab\" href=\"#settings\" role=\"tab\">Settings</a> </li>");
                                 	}
                                 
                                 %>
                            </ul>
                            <!-- Tab panes -->
                            <br>
                            <div class="tab-content">
                                <div class="tab-pane active" id="timeline" role="tabpanel">
                                    <div class="card-body">
                                        <div class="profiletimeline">
                                        
                                        	<%
                                        	
                                        		List<PostHolder> userPosts = PostDao.getUserPosts(profileId);
                                        	
                                        		if(userPosts.size() > 0){
                                        			
                                        			for(PostHolder userPost : userPosts){
                                        				
                                        				String date = HelperController.epochToDate(userPost.getPostDate());
                                        				String caption = userPost.getPostCaption();
                                        				String postType = userPost.getPostType();
                                        				String postContent = userPost.getPostContent();
                                        				int postId = userPost.getPostId();
                                        				int postLikes = userPost.getPostLikes();
                                        				int postComments = userPost.getPostComments();
                                        				
                                        				
                                        				out.println("<div class=\"sl-item\">");
                                        				out.println("<div class=\"sl-left\">");
                                        				out.println("<img src=\" " + picture + " \" alt=\"user\"class=\"img-circle\" /> ");
                                        				out.println("</div>");
                                        				out.println("<div class=\"sl-right\">");
                                        				out.println("<div>");
                                        				out.println("<span class=\"sl-date\">" + date + "</span>");
                                        				out.println("<br>");
                                        				out.println("<p>" + caption + "</p>");
                                        				out.println("<div class=\"row\">");
                                        				out.println("<div class=\"col-lg-3 col-md-6 m-b-20\">");
                                        				
                                        				if(postType.equalsIgnoreCase("text")){
                                        					out.println(postContent);
                                        				}
                                        				else if(postType.equalsIgnoreCase("media")){
                                        					out.println("<img src=\"" + HelperController.generatePath(postContent) + "\" class=\"img-responsive radius\" />");
                                        					
                                        				}
                                        				else if(postType.equalsIgnoreCase("video")){
                                        					out.println("<video width=\"200\" height=\"150\" controls>");
                                    						out.println("<source src=\"" + HelperController.generatePath(postContent) + "\" type=\"video/mp4\">");
                                    						out.println("</video>");
                                        				}
                                        				
                                        				out.println("</div>");
                                        				out.println("</div>");
                                        				out.println("<div class=\"like-comm\">");
                                        				
                                        				if(userId == profileId){
                                        					
                                        					int userLiked = userPost.getUserLiked();
                                        					if(userLiked == 1){
                                        						out.println("<i class=\"fa fa-heart text-danger\"></i> " + postLikes + "&nbsp&nbsp&nbsp");
                                        					}
                                        					else{
                                        						out.println("<a href=\"/Mutiny-JSP-Hibernate/PostController?action=addLike&page=userProfile&postType=" + postType + "&postId=" + postId + "\">");
                                        						out.println("<i class=\"fa fa-heart\"></i></a> " + postLikes + "&nbsp&nbsp&nbsp");
                                        					}
                                        					
                                        					out.println("<a href=\"/Mutiny-JSP-Hibernate/PostController?action=postComments&postType=" + postType + "&postId=" + postId + "\">");
                                        					out.println("<i class=\"fa fa-commenting-o\" aria-hidden=\"true\"></i></a> " + postComments);
                                        				}
                                        				else if(FriendDao.areFriends(userId, profileId)){
                                        					
                                        					boolean userLiked = UserDao.getUserPostLike(userId, postType, postId);
                                        					if(userLiked){
                                        						out.println("<i class=\"fa fa-heart text-danger\"></i> " + postLikes + "&nbsp&nbsp&nbsp");
                                        					}
                                        					else{
                                        						out.println("<a href=\"/Mutiny-JSP-Hibernate/PostController?action=addLike&page=userProfile&postType=" + postType + "&postId=" + postId + "\">");
                                        						out.println("<i class=\"fa fa-heart\"></i></a> " + postLikes + "&nbsp&nbsp&nbsp");
                                        					}
                                        					
                                        					out.println("<a href=\"/Mutiny-JSP-Hibernate/PostController?action=postComments&postType=" + postType + "&postId=" + postId + "\">");
                                        					out.println("<i class=\"fa fa-commenting-o\" aria-hidden=\"true\"></i></a> " + postComments);
                                        				}
                                        				else{
                                        					
                                    						out.println("<i class=\"fa fa-heart\"></i> " + postLikes + "&nbsp&nbsp&nbsp");
                                    						out.println("<i class=\"fa fa-commenting-o\" aria-hidden=\"true\"></i> " + postComments);
                                        				}
                                        				
                                        				
                                        				out.println("</div>");
                                        				out.println("</div>");
                                        				out.println("</div>");
                                        				out.println("</div>");
                                        				out.println("<hr>");
                                        				out.println("");
                                        				
                                        			}
                                        		}
                                        	
                                        	%>
                           
                           			</div>
                           		</div>
                           	</div>

                                <!--second tab-->
                                <div class="tab-pane" id="friends" role="tabpanel">
                                    <div class="card-body">
                                    
                                    <%
                                    
                                    	List<Friend> friends = FriendDao.getFriends(profileId);
                                    
                                    	if(friends.size() > 0){
                                    		
                                    		for(Friend friend : friends){
                                    			
                                    			int friendId = friend.getFriendId().getUserId();
                                    			String friendPicture = UserController.getProfilePicture(friendId);
                                    			
                                    			String friendName;
                                    			if(friendId == userId){
													friendName = "You";                                    				
                                    			}
                                    			else{
                                    				friendName = UserDao.getUsername(friendId);
                                    			}
                                    			
                                    			out.println("<div class=\"recent-comment\">");
                                    			out.println("<div class=\"media\">");
                                    			out.println("<div class=\"media-left\">");
                                    			out.println("<a href=\"/Mutiny-JSP-Hibernate/UserController?action=showUserProfile&profileId=" + friendId + "\">");
                                    			out.println("<img alt=\"...\" src=\"" + friendPicture + "\"class=\"media-object\">");
                                    			out.println("</div>");
                                        		out.println("<div class=\"media-body\">");
                                        		out.println("<h4 class=\"media-heading\">" + friendName + "</h4>");
                                        		out.println("</div></a>");
                                    			out.println("</div>");
                                    			out.println("</div>");
                                    			out.println("");
                                    			out.println("");
                                    			out.println("");
                                    		}
                                    	}
                                    
                                    %>
                                                
                                    </div>
                                </div>
                                
                                
                                <div class="tab-pane" id="communities" role="tabpanel">
                                    <div class="card-body">

                                           <%
                                    
												List<Community> communities = CommunityDao.getCommunities(profileId);
                                           
		                                    	if(communities.size() > 0){
		                                    		
		                                    		for(Community community : communities){
		                                    			
		                                    			int communityId = community.getCommunityId();
		                                    			String communityPicture = CommunityController.getCommunityPicture(communityId);
		                                    			String communityName = CommunityDao.getCommunityName(communityId);
		                                    			
		                                    			out.println("<div class=\"recent-comment\">");
		                                    			out.println("<div class=\"media\">");
		                                    			out.println("<div class=\"media-left\">");
		                                    			
		                                    		
		                                    			if(userId == profileId){
		                                    				out.println("<a href=\"/Mutiny-JSP-Hibernate/CommunityController?action=communityChat&communityId=" + communityId + "\">");
			                                    			out.println("<img alt=\"...\" src=\"" + communityPicture + "\"class=\"media-object\">");
			                                    			out.println("</div>");
		                                        			out.println("<div class=\"media-body\">");
		                                        			out.println("<h4 class=\"media-heading\">" + communityName + "</h4>");
		                                        			out.println("</div>");
		                                        			out.println("</a>");
		                                    			}
		                                    			else{
			                                    			out.println("<img alt=\"...\" src=\"" + communityPicture + "\"class=\"media-object\">");
			                                    			out.println("</div>");
		                                        			out.println("<div class=\"media-body\">");
		                                        			out.println("<h4 class=\"media-heading\">" + communityName + "</h4>");
		                                        			out.println("</div>");
		                                    			}
		                                    			
		                                    			
		                                    			out.println("</div>");
		                                    			out.println("</div>");
		                                    			out.println("");
		                                    			out.println("");
		                                    			out.println("");
		                                    		}
		                                    	}
                                    
                                    %>

                                    </div>
                                </div>
                                
                                
                                <%
                                
                                	if(userId == profileId){
                                		
                                		out.println("<div class=\"tab-pane\" id=\"settings\" role=\"tabpanel\">");
                                		out.println("<div class=\"card-body\">");
                                		out.println("<form action=\"/Mutiny-JSP-Hibernate/UserController?action=updateProfile\" enctype=\"multipart/form-data\" method=\"post\">");
                                		out.println("<div class=\"form-group\">");
                                		out.println("<div class=\"form-group row\">");
                                		out.println("<div class=\"col-lg-6 offset-md-3\">");
                                		out.println("<input type=\"text\" class=\"form-control\" id=\"status\" name=\"status\" placeholder=\"Enter your status\"/>");
                                		out.println("</div>");
                                		out.println("</div>");
                                		out.println("</div>");
                                		out.println("<br>");
                                		out.println("<div class=\"form-group row\">");
                                		out.println("<div class=\"col-lg-6 offset-md-3\">");
                                		out.println("<input type=\"file\" class=\"form-control\" id=\"profilePicture\" name=\"profilePicture\" accept=\"image/*\" />");
                                		out.println("</div>");
                                		out.println("</div>");
                                		out.println("<br>");
                                		out.println("<button type=\"submit\" id=\"login\" class=\"btn btn-primary btn-flat offset-md-6\">");
                                		out.println("Update Profile");
                                		out.println("</button>");
                                		out.println("</form>");
                                		out.println("</div>");
                                		out.println("</div>");
                                		out.println("");
                                		out.println("");
                                	}
                                
                                %>
                                  
                                    
                                
                            </div>
                        </div>
                    </div>
                    <!-- Column -->
                </div>

            </div>


            <br><br><br><br><br><br><br><br><br><br><br><br>


        </div>
    </div>
    <!-- End PAge Content -->
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

</body>

</html>