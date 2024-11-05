<%@page import="java.sql.*"%>
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
//1. JDBC DRIVER LOADING
	Class.forName("com.mysql.cj.jdbc.Driver");

	// 2. 데이터베이스 연결을 위한 정보 저장
	String jdbcURL = "jdbc:mysql://localhost:3306/jspdb_c";
	String dbUser = "root";
	String dbPass = "cksgnl!2";
	
	// 3. db connection 생성
	Connection conn = DriverManager.getConnection(jdbcURL, dbUser, dbPass);
	
%>
</body>
</html>