<%@page import="java.io.FileReader"%>
<%@page import="java.io.BufferedReader"%>
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
	String filename = request.getParameter("filename");
	//String real = application.getRealPath("/WEB-INF/board/"+filename);
	BufferedReader br = new BufferedReader(new FileReader(filename));
	
	while(true){
		String str = br.readLine();
		if(str == null )break;
		out.println(str + "<br>");
	}br.close();
%>
</body>
</html>