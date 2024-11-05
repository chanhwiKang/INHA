<%@page import="java.text.SimpleDateFormat"%>
<%@page import="java.util.Date"%>
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
	Date date = new Date();
	SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
	String strDate = sdf.format(date);
%>

<jsp:useBean id="book" class="week2.Book"/>
<jsp:setProperty property="*" name="book"/>
<jsp:setProperty property="pubDate" name="book" value="<%=strDate %>"/>

<table border="1">
	<tr>
		<td>코드</td><td>제목</td>
		<td>저자</td><td>출판일자</td>
	</tr><tr>
	<td>
		<jsp:getProperty name="book" property="code"/>
	</td><td>
		<jsp:getProperty name="book" property="title"/>
	</td><td>
		<jsp:getProperty name="book" property="writer"/>
	</td><td>
		<jsp:getProperty name="book" property="pubDate"/>
	</td>
	</tr>
</table>

</body>
</html>