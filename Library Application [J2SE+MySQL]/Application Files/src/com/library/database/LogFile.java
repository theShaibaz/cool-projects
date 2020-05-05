package com.library.database;

import java.io.FileWriter;
import java.io.IOException;
import java.io.PrintWriter;

public class LogFile {

	private LogFile() {
		
	}
	
	private static FileWriter fileWriter = null;
	public static PrintWriter printWriter = null;
	
	static {
		
		try {
			fileWriter = new FileWriter("E:\\Fullstack\\Java\\JavaTest\\Library\\src\\com\\library\\utilities\\logs.txt", true);
			printWriter = new PrintWriter(fileWriter);
		} 
		catch (IOException e) {
			e.printStackTrace();
		}
	}
	
	public static void writeLog(String logRecord) {
		
		printWriter.println(logRecord);
		printWriter.flush();
	}
}
