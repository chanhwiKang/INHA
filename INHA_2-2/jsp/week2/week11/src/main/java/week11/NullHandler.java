package week11;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class NullHandler implements IcommandHandler{

	@Override
	public String process(HttpServletRequest reqest, HttpServletResponse response) {
		// greeting 요청이 들어오면 실행되는 메소드
		reqest.setAttribute("command", "Invalid type");
		
		// 다음으로 넘길 뷰 페이지를 리턴
		return "null";
	}
	
}
