<%@page import="java.io.IOException"%>
<%@page import="java.io.FileWriter"%>
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
<h3>게시판 글쓰기 결과화면</h3>
<% request.setCharacterEncoding("utf-8");
	String name = request.getParameter("name");
	String title = request.getParameter("title");
	String content = request.getParameter("content");
	
	//게시판 글 쓴 내용을 파일로 저정
	// 파일명 = 중복 X -> 날짜 or 시간 사용
	Date date = new Date();
	Long time = date.getTime();
	
	String file = time + ".txt";
	
	String filename = application.getRealPath("/WEB-INF/board/" + file);
	
	FileWriter writer = new FileWriter(filename);
	try{
		String str = "제목 : " + title + "\n";
		str += "글쓴이 : " + name + "\n";
		str += "내용 : <br>" + content;
		writer.write(str);
		out.println("파일에 데이터를 저장하였습니다.");
	}catch(IOException e){
		out.println("파일에 데이터를 저장할 수 없습니다.");
	} finally{
		writer.close();
	}
%>

<form action="boardResult.jsp">
	<input type="hidden" name="filename" value="<%=filename %>">
	<input type="submit" value="내용보기">
</form>
</body>
</html>