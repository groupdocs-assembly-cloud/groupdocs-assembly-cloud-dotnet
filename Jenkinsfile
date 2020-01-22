properties([
	gitLabConnection('gitlab'),
	parameters([string(defaultValue: 'refs/heads/master', description: 'the branch to build', name: 'branch', trim: true)])
])

node('windows2019') {
	try {
		gitlabCommitStatus("checkout") {
			stage('checkout'){
				checkout([$class: 'GitSCM', branches: [[name: params.branch]], doGenerateSubmoduleConfigurations: false, extensions: [[$class: 'LocalBranch', localBranch: "**"]], submoduleCfg: [], userRemoteConfigs: [[credentialsId: '361885ba-9425-4230-950e-0af201d90547', url: 'https://git.auckland.dynabic.com/assembly-cloud/assembly-net-sdk.git']]])
			}
		}
		gitlabCommitStatus("build") {
			stage('build') {
				bat 'docker build scripts -f scripts\\build.Dockerfile -t netsdkbuild'
				bat 'docker run -v %CD%:C:\\Build\\ netsdkbuild c:\\build\\scripts\\build.bat' 
			}
		}
		gitlabCommitStatus("prepare test env") {
			stage('prepare test env') {		
				bat 'mkdir testResults'
				bat 'mkdir Settings'
				withCredentials([usernamePassword(credentialsId: '82329510-1355-497f-828a-b8ff8b5f6a30', passwordVariable: 'AppKey', usernameVariable: 'AppSid')]) {
					bat "echo {\"AppSid\":\"%AppSid%\",\"AppKey\":\"%AppKey%\",\"BaseUrl\":\"https://api-qa.groupdocs.cloud\" } > Settings\\servercreds.json"
				}
			}
		}
		gitlabCommitStatus("net tests") {
			stage('net tests') {	
				try {
					bat 'docker run -v %CD%:C:\\Build\\ netsdkbuild c:\\build\\scripts\\net-test.bat Test'
				} finally {
					junit '**\\testResults\\Assembly-tests-results-net452.xml'
				}
			}
		}
	} finally {
		bat 'docker system prune -f'
		deleteDir()
	}
}