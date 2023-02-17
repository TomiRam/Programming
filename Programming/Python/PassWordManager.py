import hashlib
import getpass

# create a dictionary to store the accounts and passwords
accounts = {}

def create_account(username, password):
    # hash the password
    hashed_password = hashlib.sha256(password.encode()).hexdigest()

    # add the account and hashed password to the dictionary
    accounts[username] = hashed_password

def login(username, password):
    # check if the account exists
    if username in accounts:
        # hash the entered password
        hashed_password = hashlib.sha256(password.encode()).hexdigest()

        # check if the hashed passwords match
        if accounts[username] == hashed_password:
            print("Logged in successfully.")
        else:
            print("Incorrect password.")
    else:
        print("Account does not exist.")

# create a new account
create_account("user1", "password1")

# try logging in
login("user1", "password1")
# Output : "Logged in successfully."

# try logging in with incorrect password
login("user1", "wrongpassword")
# Output : "Incorrect password."
