<%@page import="java.util.Date"%>
<%@page import="java.text.SimpleDateFormat"%>
<%@ page language="java" contentType="text/html; charset=UTF-8"
    pageEncoding="UTF-8"%>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
<title>Insert title here</title>
</head>
<body>
<% request.setCharacterEncoding("utf-8");
	Date date = new Date();
	SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
	String strDate = sdf.format(date);
%>
<jsp:useBean id="member" class="week2.MemberInfo"/>
<jsp:setProperty name="member" property="*"/>
<jsp:setProperty name="member" property="password" value="<%=member.getId() %>"/>
<jsp:setProperty property="registerDate" name="member" value="<%=strDate %>"/>
<table border="1">
	<tr>
		<td>아이디</td>
		<td><%=request.getParameter("id") %></td>
		<td>암호</td>
		<td>
			<jsp:getProperty property="password" name="member"/>
		</td>
	</tr><tr>
		<td>이름</td>
		<td><%=request.getParameter("name") %></td>
		<td>이메일</td>
		<td><%=request.getParameter("email") %></td>
	</tr><tr>
		<td>등록일자</td>
		<td colspan="3">
			<jsp:getProperty property="registerDate" name="member"/>
		</td>
	</tr>
	
</table>
</body>
</html>