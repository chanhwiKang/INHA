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
<!-- 상대 경로 읽기 -->
<%
	//String path = "test.txt";
	String path = application.getRealPath("/WEB-INF/test.txt");
	BufferedReader br = new BufferedReader(new FileReader(path));
		
	while(true){
		String str = br.readLine();
		if (str == null)break;
		out.println(str + "<br>");
	}br.close();
%>
</body>
</html>