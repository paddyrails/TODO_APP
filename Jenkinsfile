pipeline {
  agent any

  stages {
    stage("Clean Up"){
      steps {
        deleteDir()
      }
    }
     stage("Clone Repo"){
      steps {
        dir("TODO_APP"){
          // sh "git clone https://github.com/paddyrails/TODO_APP.git"
        }
      }
    }
    stage("Tag"){
      dir("TODO_APP"){
        steps {
          // sh "git clone https://github.com/paddyrails/TODO_APP.git"
        }
      }
    }
    stage("Compile & Test"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          echo "Running tests.."    
        }
      }
    }
    stage("CQM Reporting"){
      steps {
        echo "Run CQM Reporting.."    
        echo "Query Sonar Gate Quality Gate.."  
      }
    }
    stage("Query Sonar Quality Gate"){
      steps {
        dir("TODO_APP"){
          echo "Query Sonar Quality Gate.."               
        }
      }
    }
    stage("Binary to Staging (Create docker image and publish)"){
      steps {
        dir("TODO_APP"){
          echo "Running docker create.."    
          // sh "docker build -t paddypillai/todo_app:${BUILD_NUMBER} ."
          // sh "docker push paddypillai/todo_app:${BUILD_NUMBER}-release"
        }
      }
    }
    stage("Push Tag"){
      steps {
        dir("TODO_APP"){
          // sh "git clone https://github.com/paddyrails/TODO_APP.git"
        }
      }
    }
    stage("Deploy"){
      steps {
        dir("TODO_APP"){
          echo "Deploying to Live Prod and DR.."              
        }
      }
    }
  }
}
