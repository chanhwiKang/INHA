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
	String name = request.getParameter("name");
	String addr = request.getParameter("addr");
%>
	
name: <%=name %>
addr: <%=addr %>
favAnimals: <%
	String[] animals = request.getParameterValues("pet");
	for(int i=0; i<animals.length; i++){
		out.println(animals[i]);
	}
%>
</body>
</html>