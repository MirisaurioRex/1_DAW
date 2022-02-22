import java.util.Arrays;

public class Exercise1 {
	
	static boolean isFollower(int[][]users, int u1, int u2) {
		if (users[u1][u2] == 1) { //if 1 means a user follows another user
			return true;
		}
		else {
			return false;
		}
	} //end isFollower

	static int mostPopular(int[][] users) {
		int popularUser = 0;
		int counter = 0;
		int counterPopularUser = 0;

		for (int row = 0; row < users.length; row++) {
			counter = 0;
			for (int column = 0; column < users[row].length; column++) { //a nested loop to check the array
				if (row != column && isFollower(users, row, column)) {
					counter++;											//when finds a follows add +1
				}
			}
			if (counter > counterPopularUser) {							//if the an user has more followers than the las popular user they swap
				popularUser = row;
				counterPopularUser = counter;
			}
		}

		return popularUser;

	} //end mostPopular

	static int lonely(int[][] users) {
		int counter = 0;

		for (int row = 0; row < users.length; row++) {
			counter = 0;
			for (int column = 0; column < users[row].length; column++) {
				if (row != column && isFollower(users, row, column)) {
					counter++;												// if a user has followers is not lonely
				}
			}
			if (counter == 0) {						// only if 0 followes a user is lonely
				return row;
			}
		}

		return -1; //if there is no lonely user

	} //end lonely

	static boolean isGroup(int[][] users, int[]group) {
		try {
			for (int row = 0; row < group.length; row++) { //we just check if the user in the group follow among them instead of checking the whole array
				for (int column = 0; column < group.length; column++) {
					if (group[row] != group[column] && !isFollower(users, group[row], group[column])) {
						return false;
					}
				}
			}

			return true;
		}
		catch(ArrayIndexOutOfBoundsException exception) {  //if the users checked are not in the users array
			System.out.println("The number is out of range. Try a lower number");
			return false;
		}

	}// end isGroup


	public static void main (String[] args) {

		int[][] users = {					//we make a bidimensional array
			{0, 1, 1, 0, 0, 0, 1, 0, 0, 1},
			{1, 0, 1, 0, 0, 0, 1, 0, 0, 0},
			{1, 1, 0, 0, 0, 1, 0, 1, 1, 0},
			{0, 0, 0, 0, 1, 1, 0, 1, 0, 0},
			{0, 0, 0, 0, 0, 0, 1, 0, 0, 0},
			{1, 1, 1, 0, 0, 0, 1, 1, 0, 1},
			{0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
			{0, 0, 1, 0, 0, 1, 1, 0, 0, 0},
			{0, 0, 1, 0, 0, 0, 1, 0, 0, 0},
			{1, 0, 0, 0, 1, 0, 1, 1, 1, 0}
		};

		// check if a user follows another user
		int u1= 3, u2= 4;
		if (isFollower(users, u1, u2)) {
			System.out.printf("The user %d follows user %d", u1, u2);
		}
		else {
			System.out.printf("The user %d does NOT follow user %d", u1, u2);
		}

		// check the most popular user
		System.out.printf("The most popular user is %d \n", mostPopular(users));

		// check if there is a lonely user
		System.out.printf("The lonely user is %d \n", lonely(users));

		// check if a bunch of users form a group. We have 3 groups to check different cases.
		int [] group1 = {2, 5, 7};
		int [] group2 = {2, 5, 0};
		int [] group3 = {2, 5, 10};

		System.out.printf("The users %s form a group?: %b \n", Arrays.toString(group1), isGroup(users, group1)); //return true
		System.out.printf("The users %s form a group?: %b \n", Arrays.toString(group2), isGroup(users, group2)); // return false
		System.out.printf("The users %s form a group?: %b \n", Arrays.toString(group3), isGroup(users, group3)); // return exception


	} // end of main
}
