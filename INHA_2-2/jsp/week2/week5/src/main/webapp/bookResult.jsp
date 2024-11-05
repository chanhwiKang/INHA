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
<style>
td{
	text-align: center;
}
</style>
<body>
<%
	request.setCharacterEncoding("utf-8");
	SimpleDateFormat sdf = new SimpleDateFormat("yyyy-MM-dd");
	Date date = new Date();
	String strDate = sdf.format(date);
%>
<jsp:useBean id="book" class="week5.Book" />
<jsp:setProperty property="*" name="book"/>
<jsp:setProperty property="pubDate" name="book" value="<%= strDate%>"/>

<h3> 도서 등록 결과</h3>
<table border="1" cellpadding="3">
		<tr bgcolor="violet">
			<td> 코드</td><td> 제목</td><td>저자</td><td>출판일자</td>			
		</tr>
		<tr>
			<td><%=book.getCode() %></td><td><%=book.getTitle() %></td>
			<td><%=book.getWriter() %></td><td><%=book.getPubDate() %></td>
		</tr>
	</table>
</body>
</html>