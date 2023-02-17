using System;
using System.IO;


using CenterSpace.NMath.Core;
using CenterSpace.NMath.Stats;

namespace CenterSpace.NMath.Stats.Examples.CSharp
{
  class SimpleLinearRegressionExample
  {

    static void Main( string[] args )
    {
      // Read in data from the file. The data comes from The Data and Story 
      // Library (http://lib.stat.cmu.edu/DASL) and is described below:
      //
      // Results of a study of gas chromatography, a technique which is used 
      // to detect very small amounts of a substance. Five measurements were
      // taken for each of four specimens containing different amounts of the
      // substance. The amounts of the substance in each specimen was determined
      // before the experiment. The responses variable is the output reading 
      // from the gas chromatograph. The purpose of the study is to calibrate
      // the chromatograph by relating the actual amounts of the substance to
      // the chromatograph reading.
      StreamReader dataStream = new StreamReader( "SimpleLinearRegressionExample.dat" );

      // First read in the independent (or predictor) values. This is a matrix
      // with one column and a row for each amounts measurement.
      var amounts = new DoubleMatrix( dataStream );

      // Next, read in the responses. These are the readings of the gas 
      // chromatograph
      var responses = new DoubleVector( dataStream );

      // Print out the amounts and responses values.
      Console.WriteLine();
      Console.WriteLine( "amounts = {0}", amounts );
      Console.WriteLine( "responses = {0}", responses );

      // Construct a linear regression. If we want our regression to calculate a
      // y-intercept we must send in true for the "addIntercept" parameter (the
      // third parameter in the constructor).
      var regression = new LinearRegression( amounts, responses, true );

      // The y-intercept is the first element of the parameter array returned by 
      // the regression, and the slope is the second.
      Console.WriteLine( "y-intercept = {0}", regression.Parameters[0] );
      Console.WriteLine( "Slope = {0}", regression.Parameters[1] );

      // What would the model predict for the chromatograph reading for an
      // input amounts of 0.75 and 1.25?
      var amount = new DoubleVector( 0.75 );
      double predictedReading = regression.PredictedObservation( amount );
      Console.WriteLine( "Predicted reading for amount {0} is {1}", amount[0], predictedReading );
      amount[0] = 1.25;
      predictedReading = regression.PredictedObservation( amount );
      Console.WriteLine( "Predicted reading for amount {0} is {1}", amount[0], predictedReading );

      // Let's look at the coefficient of determination for the model - Rsquared.
      // To do this we will need to construct an Analysis Of VAriance object for 
      // the regression.
      var regressionAnova = new LinearRegressionAnova( regression );
      Console.WriteLine( "Rsquare = {0}", regressionAnova.RSquared );

      Console.WriteLine();
      Console.WriteLine( "Press Enter Key" );
      Console.Read();

    } // Main

  } // class

} // namespace

