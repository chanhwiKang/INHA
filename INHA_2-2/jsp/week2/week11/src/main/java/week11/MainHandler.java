package week11;

import javax.servlet.http.HttpServletRequest;
import javax.servlet.http.HttpServletResponse;

public class MainHandler implements IcommandHandler{

	@Override
	public String process(HttpServletRequest reqest, HttpServletResponse response) {
		
		
		// 다음으로 넘길 뷰 페이지를 리턴
		return "index";
	}
	
}
