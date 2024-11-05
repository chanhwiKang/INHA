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
<h3>db connect</h3>
<%
	// 1. JDBC DRIVER LOADING
	Class.forName("com.mysql.cj.jdbc.Driver");

	// 2. 데이터베이스 연결을 위한 정보 저장
	String jdbcURL = "jdbc:mysql://localhost:3306/jspdb_c";
	String dbUser = "root";
	String dbPass = "cksgnl!2";
	
	// 3. db connection 생성
	Connection conn = DriverManager.getConnection(jdbcURL, dbUser, dbPass);
	
	// 4. 쿼리 실행을 위한 sql 문장, Statement 객체 생성
	String sql = "select * from emp";
	Statement stat = conn.createStatement();
	
	// 5. 쿼리 실행 후 결과 저장
	ResultSet rs = stat.executeQuery(sql);
	
	// 6. 쿼리 실행 결과
	if(rs != null){
		out.println("데이터베이스 연결 성공");
	} else {
		out.println("데이터베이스 연결 실패");
	}
	rs.close();
	stat.close();
	conn.close();
%>
</body>
</html>