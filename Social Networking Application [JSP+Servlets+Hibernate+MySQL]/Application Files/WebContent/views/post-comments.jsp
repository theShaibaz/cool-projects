<%@ page language="java" contentType="text/html; charset=ISO-8859-1" pageEncoding="ISO-8859-1" %>

<%@ page import="com.mutiny.dao.UserDao" %>
<%@ page import="com.mutiny.dao.PostHolder" %>
<%@ page import="com.mutiny.dao.PostCommentHolder" %>
<%@ page import="java.util.ListIterator" %>

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
       	
       		String postType = (String)session.getAttribute("postType");
       		int postId = (int)session.getAttribute("postId");
       		PostHolder post = PostController.getPost(postType,postId,session);
       
       		List<PostCommentHolder> comments = PostController.getPostComments(postId, postType);
       		
       		int postedBy = post.getPostedBy();
      	 
       
       %>
       
        <div class="container">
        	<div class="container-fluid">
                <div class="row">
                    <div class="col-lg-10 offset-sm-1">
                        <div class="card">
                            <div class="card-title">
                                <div class="recent-comment">
                                    <div class="media">
                                        <div class="media-left">
                                            
                                            <%
                                            
                                            	out.println("<a href=\"/Mutiny-JSP-Hibernate/UserController?action=showUserProfile&profileId=" + postedBy + "\">");
                                            	out.println("<img alt=\"...\" src=\"" + UserController.getProfilePicture(postedBy) + "\" class=\"media-object\"></a>");
                                            
                                            %>
                                            
                                        </div>
                                        <div class="media-body">
                                        
                                        	<%
                                        	
	                                        	if(postedBy == userId){
	                        						out.println("<h4 class=\"media-heading\">You</h4>");
	                        					}
	                        					else{
	                        						out.println("<h4 class=\"media-heading\">" + UserDao.getUsername(postedBy) + "</h4>");
	                        					}
                                        	
                                        		out.println("<p class=\"comment-date\">" + HelperController.epochToDate(post.getPostDate()) + "</p>");
                                        	
                                        	%>
                                            
                                        </div>
                                    </div>
                                </div>
                            </div>

                            <br>
                            
                            <%
                            	
	                            if(postType.equalsIgnoreCase("text")){
	        						
	        						out.println("<div class=\"card-body\">");
	        						out.println("<h3>" + post.getPostCaption() + "</h3>");
	        						out.println(post.getPostContent());
	        						out.println("</div>");
	        						
	        					}
	        					else if(postType.equalsIgnoreCase("media")){
	        						
	        						out.println("<div class=\"card-body\">");
	        						out.println("<h3>" + post.getPostCaption() + "</h3>");
	        						out.println("<img src=\"" + HelperController.generatePath(post.getPostContent()) + "\" alt=\"\" width=\"100%\" height=\"500\">");
	        						out.println("</div>");
	        						
	        					}
	        					else if(postType.equalsIgnoreCase("video")){
	
	        						out.println("<div class=\"card-body\">");
	        						out.println("<h3>" + post.getPostCaption() + "</h3>");
	        						out.println("<video width=\"100%\" height=\"500\" controls>");
	        						out.println("<source src=\"" + HelperController.generatePath(post.getPostContent()) + "\" type=\"video/mp4\">");
	        						out.println("</video>");
	        						out.println("</div>");
	        					}
                            
                            
                            %>
                            
                            <br>

                            <div class="card-footer">

							<%
							
								if(post.getUserLiked() == 1){
									out.println("<i class=\"fa fa-heart text-danger\"></i></a> " + post.getPostLikes());									
								}
								else{
									out.println("<a href=\"/Mutiny-JSP-Hibernate/PostController?action=addLike&page=postComments&postType=" + postType + "&postId=" + postId + "\">");
									out.println("<i class=\"fa fa-heart\"></i></a> " + post.getPostLikes());
								}
								out.println("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
								out.println("<i class=\"fa fa-commenting-o\" aria-hidden=\"true\"></i> " + post.getPostComments());
								out.println("</span>");
								
							%>

                            </div>
                        </div>
                    </div>
                </div>

				<%
                                    	
                	out.println("<form action=\"/Mutiny-JSP-Hibernate/PostController?action=addComment&postType=" + postType + "&postId=" + postId + "\" method=\"post\">");
                                    	
                %>
                <div class="row">
                    <div class="col-lg-10 offset-sm-1">
                        <div class="card">
                            <div class="card-title"></div>
                            <br>
                            <div class="card-body">
                                <div class="form-group ">
                                    <div class="col-lg-12">
                                        <textarea class="form-control" id="commentText" name="commentText" placeholder="Enter comment here" rows="50" style="height:90px;"></textarea>
                                    </div>
                                </div>
                                <div class="form-group col-lg-12">
                                    <button type="submit" id="login" class="btn btn-primary btn-flat float-right">
                                        Post Comment
                                    </button>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
				<%
				
					out.println("</form>");
				
				%>
	
				<div class="row">
                    <div class="col-lg-10 offset-sm-1">
	

				<%
				
					if(comments.size() > 0){
						
						
						for(PostCommentHolder comment : comments){
							
							int commentBy = comment.getCommentby();
							String picture = UserController.getProfilePicture(commentBy);
							String name = UserDao.getUsername(commentBy);
							String date = HelperController.epochToDate(comment.getCommentOn());
							String text = comment.getCommentContent();
							
							out.println("<div class=\"card\">");
							out.println("<div class=\"card-title\">");
							out.println("<div class=\"recent-comment\">");
							out.println("<div class=\"media\">");
							out.println("<div class=\"media-left\">");
							out.println("<a href=\"/Mutiny-JSP-Hibernate/UserController?action=showUserProfile&profileId=" + commentBy + "\">");
							out.println("<img alt=\"...\" src=\"" + picture + "\" class=\"media-object\"></a>");
							out.println("</div>");
							out.println("<div class=\"media-body\">");
							
							if(comment.getCommentby() == userId){
								out.println("<h4 class=\"media-heading\">You</h4>");
							}
							else{
								out.println("<h4 class=\"media-heading\">" + name + "</h4>");
							}
							
							out.println("<p class=\"comment-date\">" + date + "</p>");
							out.println("</div>");
							out.println("</div>");
							out.println("</div>");
							out.println("</div>");
							out.println("<br>");
							out.println("<div class=\"card-body\">");
							out.println(text);
							out.println("</div>");
							out.println("</div>");
							out.println("");
						}
					}
				
				%>

		<br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br><br>

			 </div>
       	 </div>

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

</body>

</html>