package ilstu.edu;

public class MorseCode {

	private Node root;

	public MorseCode() {
		root = new Node(" ", ' ');
	}


	public String toString() {
		StringBuilder sb = new StringBuilder();
		this.toString(sb, this.root, 0);
		return sb.toString();
	}

	public void toString(StringBuilder sb, Node curRoot, int lvl) {
		if (curRoot != null) {
			this.toString(sb, curRoot.leftBranch, lvl + 1);
			for (int i = 0; i < lvl; i++)
				sb.append("\t");
			sb.append("Level ");
			sb.append(lvl);
			sb.append(": (\'");
			sb.append(curRoot.codeLetter);
			sb.append("\', \"");
			sb.append(curRoot.codeStr);
			sb.append("\"");
			sb.append(")");
			sb.append("\n");
			this.toString(sb, curRoot.rightBranch, lvl + 1);

		}
	}

	public void add(String codeStr, char codeLetter) {
		Node pass = new Node(codeStr, codeLetter);
		this.add(this.root, pass, 0);
	}

	private void add(Node curRoot, Node pass, int lvl) {
		if (lvl != pass.codeStr.length())
		if (pass.codeStr.charAt(lvl) == '•' || pass.codeStr.charAt(lvl) == '.') {
			if (curRoot.leftBranch == null) {
				if (lvl == pass.codeStr.length() - 1) {
					curRoot.leftBranch = pass;
				} else {
					curRoot.leftBranch = new Node(" ", ' ');
					 add(curRoot.leftBranch, pass, lvl + 1);
				

				}

			} else {
				if ((lvl == pass.codeStr.length() - 1 && curRoot.leftBranch.codeLetter == ' ')) {
					curRoot.leftBranch.codeLetter = pass.codeLetter;
					curRoot.leftBranch.codeStr = pass.codeStr;
			

				} else
					 add(curRoot.leftBranch, pass, lvl + 1);
			}

		} else if (pass.codeStr.charAt(lvl) == '_' || pass.codeStr.charAt(lvl) == '-') {
			if (curRoot.rightBranch == null) {
				if (lvl == pass.codeStr.length() - 1) {
					curRoot.rightBranch = pass;
				

				} else {
					curRoot.rightBranch = new Node(" ", ' ');
					 add(curRoot.rightBranch, pass, lvl + 1);
					
				}

			} else {
				if (lvl == pass.codeStr.length() - 1 && curRoot.rightBranch.codeLetter == ' ') {
					curRoot.rightBranch.codeLetter = pass.codeLetter;
					curRoot.rightBranch.codeStr = pass.codeStr;
			

				} else
					 add(curRoot.rightBranch, pass, lvl + 1);
			}
		}

	}

	public char decode(String codeStr) {
		return this.decode(codeStr,0,root);
	}
	private char decode(String codeStr,int lvl,Node curRoot) {
		if(codeStr.equals(" ")) {
			return ' ';
		}else {
			if(lvl==codeStr.length()-1) {
				if(codeStr.charAt(lvl)=='•'||codeStr.charAt(lvl)=='.') {
					return curRoot.leftBranch.codeLetter;
				}
				else {
					return curRoot.rightBranch.codeLetter;
				}
			}else {
				if(codeStr.charAt(lvl)=='•'||codeStr.charAt(lvl)=='.') {
					return decode(codeStr,lvl+1,curRoot.leftBranch);
				}
				else {
					return decode(codeStr,lvl+1,curRoot.rightBranch);
				}
			}
		}
			
	}
	
	private static class Node {
		private String codeStr;
		private char codeLetter;
		private Node leftBranch;
		private Node rightBranch;

		public Node(String codeStr, char codeLetter) {
			this.codeStr = codeStr;
			this.codeLetter = codeLetter;
		}
	}
}
