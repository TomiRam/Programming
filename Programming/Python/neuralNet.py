
import numpy as np

# Create Dataset
X = np.array([[0,0],
			  [0,1],
			  [1,0],
			  [1,1]])

y=np.array([[0],
			[1],
			[1],
			[0]])

#Convert to tensors.
X= tf.convert_to_tensor(X, dtype=tf.float16)
y= tf.convert_to_tensor(y, dtype=tf.float16)

# Randomly initialize two weight matrices
# w1 is a matrix with dims [2,3]
# w2 is a matrix with dims [3,1]
# Casting them to Variable since value can be changed during
# optimisation
w1 = tf.Variable(np.random.randn(2,3), dtype=tf.float16)
w2 = tf.Variable(np.random.randn(3,1), dtype=tf.float16)

#Create a function that progates x through the network
@tf.function
def forward(X,w1,w2):
	X=tf.sigmoid(tf.matmul(X,w1))
	X=tf.sigmoid(tf.matmul(X,w2))
	return X

#Print
print(forward(X,w1,w2))
