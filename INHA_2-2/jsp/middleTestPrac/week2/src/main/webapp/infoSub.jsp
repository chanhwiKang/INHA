<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<% 
	String type = request.getParameter("type");
	if (type == null)return;
%>
<br>
<table width="100%" border="1">
	<tr><td>type</td><td><b><%=type %></b></tr>
	<tr><td>특징</td><td>
		<% if (type.equals("iPhone")){%>
			beautiful
			<% }else {%>
			not good<%} %>
			
	</td></tr>
</table>
</body>
</html>