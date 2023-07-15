pipeline {
  agent any

  stages {
    stage("Clean Up"){
      steps {
        deleteDir()
        echo "${BRANCH_NAME}"
      }
    }
     stage("Clone Repo"){
      steps {
        echo "Cloning Repo"
        // sh "git clone https://github.com/paddyrails/TODO_APP.git"
      }
    }
    stage("Build"){
      steps {
        dir("TODO_APP"){
          echo "Running build.."    
          echo "running tests.."
        }
      }
    }
    stage("Code scan"){
      steps {  
         script {     
          dir("TODO_APP"){
              if((env.BRANCH_NAME).startsWith('PR-')){
              echo "Run CQM Reporting.."    
              echo "Query Sonar Gate Quality Gate.."            
            }
          }     
         }   
      }
    }
  }
}
