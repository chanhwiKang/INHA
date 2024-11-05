<%@page import="java.sql.ResultSet"%>
<%@page import="java.sql.Statement"%>
<%@page import="java.sql.DriverManager"%>
<%@page import="java.sql.Connection"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<h3>사원 목록</h3>
<table border="1" width="100%" style="text-align: center;">
	<tr>
		<td>사원번호</td>
		<td>사원이름</td>
		<td>부서코드</td>
		<td>업무</td>
		<td>급여</td>
	</tr>
	<%
		Class.forName("com.mysql.cj.jdbc.Driver");

		String jdbcURL = "jdbc:mysql://localhost:3306/jspdb_c";
		String dbUser = "root";
		String dbPass = "cksgnl!2";
		
		Connection conn = DriverManager.getConnection(jdbcURL, dbUser, dbPass);
		
		String sql = "select * from emp";
		Statement stat = conn.createStatement();
		
		ResultSet rs = stat.executeQuery(sql);
		
		while(rs.next()){
			out.println("<tr><td>");
			out.println(rs.getString("empno") + "</td><td>");
			out.println(rs.getString("empname") + "</td><td>");
			out.println(rs.getString("empdept") + "</td><td>");
			out.println(rs.getString("empjob") + "</td><td>");
			out.println(rs.getString("empsal") + "</td><tr>");
		}
		rs.close();
		stat.close();
		conn.close();
	%>
</table>

</body>
</html>