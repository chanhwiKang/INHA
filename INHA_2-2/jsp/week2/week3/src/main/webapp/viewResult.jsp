
<%@page import="java.util.Enumeration"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h2>request Header 정보 </h2>

<%
	Enumeration headerEnum = request.getHeaderNames();
	while(headerEnum.hasMoreElements()){
		String hName = (String)headerEnum.nextElement();
		String hValue = request.getHeader(hName);
		out.println(hName + " = " + hValue + "<br>");
	}
%>


</body>
</html>